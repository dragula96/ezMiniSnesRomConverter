#!/usr/bin/env python

# Permission to use, copy, modify, and/or distribute this software for any
# purpose with or without fee is hereby granted.
#
# THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH
# REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY
# AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT,
# INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM
# LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR
# OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR
# PERFORMANCE OF THIS SOFTWARE.

import argparse
from struct import pack


ROM_SIZE = {0x08: 0x40000,
            0x09: 0x80000,
            0x0A: 0x100000,
            0x0B: 0x200000,
            0x0C: 0x400000}


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

    return 0x0


def get_super_fx(data, rom_format):
    """Returns 0x0C if the ROM uses a Super-FX chip, otherwise 0x0"""

    SFX_TYPES = [0x13, 0x14, 0x15, 0x1a]

    if (rom_format == 0x14 and rom[0x7FD6] in SFX_TYPES)\
    or (rom_format == 0x15 and rom[0xFFD6] in SFX_TYPES):
        return 0x0C

    return 0x0


if __name__ == "__main__":
    parser = argparse.ArgumentParser(description="""Converts SNES ROMs to .sfrom for
                                                  the SNES Classic""")
    parser.add_argument('input', type=argparse.FileType('rb'))
    parser.add_argument('output', type=argparse.FileType('wb'))
    args = parser.parse_args()

    # Read in entire file because who needs RAM
    rom = args.input.read()
    args.input.close()

    # Strip out potential header
    rom = rom[len(rom) % 0x400:]

    # Simple header format
    # Start Size Type Contents
    # 0x00  0x04 I    0x100
    # 0x04  0x04 I    File size
    # 0x08  0x04 I    0x50
    # 0x0C  0x08 8x   0x0
    # 0x14  0x04 I    0x30
    # 0x18  0x19 25x  0x0
    # 0x31  0x04 I    ROM Size
    # 0x35  0x08 8x   0x0
    # 0x3D  0x02 H    Game preset ID
    # 0x3F  0x02 2x   0x0
    # 0x41  0x01 B    ROM format (hi/lo)
    # 0x42  0x01 B    Super-FX ? 0x0C : 0x0
    # 0x43  0x0D 13x  0x0

    rom_format = get_format(rom)
    if not rom_format:
        print("Can't get ROM format. Corrupted?")
        args.output.close()
        quit(-1)

    header = pack('<3I8xI25xI8xH2x2B13x',
                  0x100,
                  len(rom) + 0x50,
                  0x50,
                  0x30,
                  len(rom),
                  get_preset_id(rom, rom_format),
                  rom_format,
                  get_super_fx(rom, rom_format))

    args.output.write(header + rom)
    args.output.close()