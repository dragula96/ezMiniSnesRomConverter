using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace miniSnesToolsGUI
{


    public partial class Form1 : Form
    {
        
        string scriptName = @"convert.bat";
        string outputFolder;
        string gameIDString;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "snes Files(*.sfc;*.smc)|*.sfc;*.smc| All files(*.*) |*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textFileName.Text = openFileDialog1.FileName;
              

            }
        }



        private void convertFile()
        {
            lblLog.Text = "converting file.";
            lblLog.Refresh();
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = scriptName;
            proc.Start();
            proc.WaitForExit();
           
            
        }

        static public void CopyTempFolderToFinalDestination(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }
            
        }

        private void moveFolderToOutputFolder()
        {
            lblLog.Text = "Moving game folder from temp location  to Output Folder.";
            lblLog.Refresh();
            string currentDir = System.IO.Directory.GetCurrentDirectory() + @"\"+ gameIDString;
            outputFolder = txtOutputFolder.Text + @"\" + gameIDString;

                   

            try
            {
                CopyTempFolderToFinalDestination(currentDir, outputFolder);
              
            }
            catch (Exception e)
            {
                MessageBox.Show("A Folder with the name: " + gameIDString + " already exists, manualy delete folder and try again.", "OH DEAR!");
            }
            Directory.Delete(currentDir, true);
            bool directoryExists = Directory.Exists(currentDir);

           
        }

        private void copyOriginalRomToTemp()
        {
            lblLog.Text = "copying original rom to temp file.";
            lblLog.Refresh();
            string currentDir = System.IO.Directory.GetCurrentDirectory();
            string sourceFile = openFileDialog1.FileName;
            string destFile = currentDir + @"\temp.smc";
            try
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            catch (Exception e) {
                MessageBox.Show("Something Went Wrong (probably with a file/folder getting moved around), just try again it will work... eventualy.", "OH DEAR!");
            }
        }
        private void copyFileToDir()
        {
            lblLog.Text = "copying temp sfrom to final game folder.";
            lblLog.Refresh();
            string currentDir = System.IO.Directory.GetCurrentDirectory();
            string sourceFile = currentDir + @"\temp.sfrom";
            string destFile = currentDir + @"\" + gameIDString + @"\" + gameIDString+ @".sfrom" ;


            //MOVE sfrom file
            try
            {
                System.IO.File.Move(sourceFile, destFile);
            }
            catch (Exception e)
            {
               
            }

            //MOVE boxart file
            // sourceFile = currentDir + @"\" + gameIDString + @".png";
            // destFile = currentDir + @"\" + gameIDString + @"\" + gameIDString + @".png";
            // System.IO.File.Move(sourceFile, destFile);
            //delete file after copy
            // File.Delete(sourceFile);
        }
        private void makeDir()
        {
            lblLog.Text = "creating game folder.";
            lblLog.Refresh();
            //Create a new subfolder under the current active folder
            string activeDir = System.IO.Directory.GetCurrentDirectory();
            string newPath = System.IO.Path.Combine(activeDir, gameIDString);

            // Create the subfolder
            try
            {
                System.IO.Directory.CreateDirectory(newPath);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something Went Wrong Creating a Folder, just try again it will work... eventualy.", "OH DEAR!");

            }

        }
        private void savePictureFile()
        {

            lblLog.Text = "saving picture files.";
            lblLog.Refresh();
            using (Bitmap bitmap = new Bitmap(228, 160))
                {
                    pictureBoxArt.DrawToBitmap(bitmap, pictureBoxArt.ClientRectangle);
                  
                   
                    bitmap.Save(System.IO.Directory.GetCurrentDirectory() + @"\" + gameIDString + @"\" + gameIDString + @".png", System.Drawing.Imaging.ImageFormat.Png);

                }

            using (Bitmap bitmap2 = new Bitmap(40, 28))
            {
                pictureBoxArt2.DrawToBitmap(bitmap2, pictureBoxArt2.ClientRectangle);
                

                bitmap2.Save(System.IO.Directory.GetCurrentDirectory() + @"\" + gameIDString + @"\" + gameIDString + @"_small.png", System.Drawing.Imaging.ImageFormat.Png);

            }


        }
        private  bool checkAllInfoFilledOut()
        {
            //checks to see if any info has been left blank (at least its a start)
            if(textFileName.Text == "")
             return true;
            if (textImageFile.Text == "")
                return true;
            if (txtID.Text == "")
                return true;
            if (txtPublisher.Text == "")
                return true;
            if (txtReleaseDate.Text == "")
                return true;
            if (txtOutputFolder.Text == "")
                return true;
            if (textGameName.Text == "")
                return true;

            return false;
        }
        private void cmdStart_Click(object sender, EventArgs e)
        {
            //WARNING: MESSAING WITH THE ORDER WILL BREAK THE PROGRAM
           bool abort =  checkAllInfoFilledOut();
            if (!abort)
            {
                lblLog.Text = "PLEASE WAIT...";
                lblLog.Refresh();
                gameIDString = "CLV-P-" + txtID.Text;
                copyOriginalRomToTemp();
                makeDir();
                createDesktopFile();
                savePictureFile();
                convertFile();
                copyFileToDir();
                convertToUnixFile();

                moveFolderToOutputFolder();
                lblLog.Text = "DONE!";
            }
            else { MessageBox.Show(" Please fill out all information, then try again.","HEY, LISTEN!"); }
        }

        private void convertToUnixFile()
        {
            lblLog.Text = "converting .desktop file to unix type.";
            lblLog.Refresh();
            const byte CR = 0x0D;
            const byte LF = 0x0A;
            string fileName = System.IO.Directory.GetCurrentDirectory() + @"\"+  gameIDString + @"\" + gameIDString + ".desktop";
            byte[] data = File.ReadAllBytes(fileName);
            using (FileStream fileStream = File.OpenWrite(fileName))
            {
                BinaryWriter bw = new BinaryWriter(fileStream);
                int position = 0;
                int index = 0;
                do
                {
                    index = Array.IndexOf<byte>(data, CR, position);
                    if ((index >= 0) && (data[index + 1] == LF))
                    {
                        // Write before the CR
                        bw.Write(data, position, index - position);
                        // from LF
                        position = index + 1;
                    }
                }
                while (index >= 0);
                bw.Write(data, position, data.Length - position);
                fileStream.SetLength(fileStream.Position);
            }
        }

       
        private void createDesktopFile()
        {
            lblLog.Text = "creating .desktop file.";
            lblLog.Refresh();
            string activeDir = System.IO.Directory.GetCurrentDirectory();

            //STRINGS FOR .DESKTOP FILE
            string thirdline = @"Exec=/usr/bin/clover-canoe-shvc -rom /usr/share/games/" + gameIDString + @"/" + gameIDString + @".sfrom --volume 100 -rollback-snapshot-period 600";
            string fourthline = @"Path=/var/lib/clover/profiles/0//" + gameIDString;
            string fithline = @"Name=" + textGameName.Text;
            string sixthline = @"Icon=/usr/share/games/" + gameIDString + @"/" + gameIDString + @".png";
            string ninthline = @"Code=" + gameIDString;
            string thirteenthline;
            if (radioPlayers1.Checked == true) {
                 thirteenthline = "Players=1";
            }else { thirteenthline = "Players=2"; }

            string fourteenline;
            if (checkSimutanious.Checked == true)
            {
                fourteenline = "Simultaneous=1";
            }
            else { fourteenline = "Simultaneous=0"; }

            string fifteenLine = @"ReleaseDate=" + txtReleaseDate.Text;
            string sixteenline;
            
            if (checkSaveFeature.Checked == true)
            {
                sixteenline = @"SaveCount=1";
            }
            else { sixteenline = @"SaveCount=0"; }

            string seventeenthline = @"SortRawTitle=" + textGameName.Text.ToLower();
            string eighteenline = @"SortRawPublisher=" + txtPublisher.Text;
            string nineteenline = @"Copyright=" + textGameName.Text + @"™ ©" + txtReleaseDate.Text + " " + txtPublisher.Text;

            // Create a string array lines.
            string[] lines = { "[Desktop Entry]", "Type=Application", thirdline,fourthline,fithline,sixthline,"",
                                 @"[X-CLOVER Game]",ninthline,"TestID=0","Status=Completing-3","ID=0",thirteenthline,
                                 fourteenline,fifteenLine,sixteenline,seventeenthline,eighteenline
                                   ,nineteenline, @"MyPlayDemoTime=45",""};
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllLines(activeDir + @"\" + gameIDString +@"\"+ gameIDString+ @".desktop", lines);
        }

        private void cmdImageFile_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png| All files(*.*) |*.*";
            openFileDialog2.FilterIndex = 1;
            openFileDialog2.RestoreDirectory = true;
            openFileDialog2.FileName = "";
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textImageFile.Text = openFileDialog2.FileName;
                pictureBoxArt.Load(textImageFile.Text);
                pictureBoxArt2.Load(textImageFile.Text);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblLog.Text = "";
            checkSimutanious.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioPlayers1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPlayers1.Checked == true)
            {
                checkSimutanious.Checked = false;
                checkSimutanious.Enabled = false;
            }
            else { checkSimutanious.Enabled = true; }
        }

        private void checkSimutanious_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed by: th3Darkness, A.K.A. Dragula96");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmdSelectOutputFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolder.Text = folderBrowserDialog1.SelectedPath;
               
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textImageFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text.ToUpper();
            txtID.Select(txtID.Text.Length, 0);
        }
    }
}
