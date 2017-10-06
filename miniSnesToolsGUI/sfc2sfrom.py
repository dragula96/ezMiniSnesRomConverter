#!/usr/bin/env python3
# script by Shabbypenguin from reddit
# fixes 2 player not working from previous used script

import string
from random import choices
from struct import pack
import argparse

parser = argparse.ArgumentParser()
parser.add_argument('input', type=str)
parser.add_argument('output', type=str)
args = parser.parse_args()

romfile = open(args.input, "rb")
rom = romfile.read()
romfile.close()

def get_format(data):
    """Returns 0x14 for LoROM and 0x15 for HiROM"""

    # Kind of lazy way of detecting this
    if all(31 < char < 127 for char in rom[0x7FC0:0x7FC0 + 21]):
        return 0x14
    if all(31 < char < 127 for char in rom[0xFFC0:0xFFC0 + 21]):
        return 0x15
    return None
	
def get_preset_id(data, rom_format):
    """Returns a preset ID for some known games, otherwise 0x0"""

    name = None
    if rom_format == 0x14:
        name = rom[0x7FC0:0x7FC0 + 21].decode('ascii').strip()
    elif rom_format == 0x15:
        name = rom[0xFFC0:0xFFC0 + 21].decode('ascii').strip()

    if name == "MEGAMAN X2":
        return 0x1117
    if name == "MEGAMAN X3":
        return 0x113D
    if name == "PILOTWINGS":
        return 0x10BD
    if name == "KIRBY'S DREAM LAND 3":
        return 0x109C

    return 0x1011

def get_super_fx(data, rom_format):
    """Returns 0x0C if the ROM uses a Super-FX chip, otherwise 0x0"""

    SFX_TYPES = [0x13, 0x14, 0x15, 0x1a]

    if (rom_format == 0x14 and data[0x7FD6] in SFX_TYPES)\
    or (rom_format == 0x15 and data[0xFFD6] in SFX_TYPES):
        return 0x0C

    return 0x0

# Strip out potential header
rom = rom[len(rom) % 0x400:]
romsize = len(rom)
filesize = romsize + 0x60
endofrom = romsize + 0x30
fileend = filesize - 0x15
gameid = "WUP-J" + ''.join(choices(string.ascii_uppercase, k=2)) + "E"

header = pack('<7I4xI8s4x',
              0x00000100,
              filesize,
              0x00000030,
              endofrom,
              endofrom,
              endofrom,
              filesize,
              fileend,
              gameid.encode(encoding='UTF-8'))

emuspeed = 0x3C
volume = 0x64


rom_format = get_format(rom)
if not rom_format:
    print("Can't get ROM format. Corrupted?")
    args.output.close()
    quit(-1)

footer = pack('<BI8xH3B0x2I22x',
              emuspeed,
              romsize,
              get_preset_id(rom, rom_format),
              0x2,
              volume,
              rom_format,
              get_super_fx(rom, rom_format),
              0x000)

out = header + rom + footer

outfile = open(args.output, "wb")
outfile.write(out)
outfile.close()