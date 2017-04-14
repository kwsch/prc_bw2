using System;

namespace POKEMON_BW2
{
    public class PokemonData
    {
        private byte[] data = new byte[0x4c];
        public const int MACHINE_SIZE = 13;
        public const int SIZE = 0x4c;

        private int ByteOfInt(int value)
        {
            if (value > 0xff)
            {
                value = 0xff;
            }
            else if (value < -256)
            {
                value = -256;
            }
            return value & 0xff;
        }

        public int GetMachine(int index)
        {
            MachineIndexCheck(index);
            return data[0x1c + index];
        }

        public int[] GetMachineArray()
        {
            int[] numArray = new int[13];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = GetMachine(i);
            }
            return numArray;
        }

        public int GetMachineLength()
        {
            return 13;
        }

        public bool IsMachineUsable(int index)
        {
            int num = index / 8;
            int num2 = index % 8;
            int num3 = (data[40 + num] >> num2) & 1;
            if (num3 != 1)
            {
                return false;
            }
            return true;
        }

        private void MachineIndexCheck(int index)
        {
            if ((index < 0) || (index >= 13))
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void SetMachine(int index, int value)
        {
            MachineIndexCheck(index);
            data[0x1c + index] = (byte) ByteOfInt(value);
        }

        public void SetMachineArray(int[] machine)
        {
            for (int i = 0; i < machine.Length; i++)
            {
                SetMachine(i, machine[i]);
            }
        }

        public void SetMachineUsable(int index, bool value)
        {
            int num = index / 8;
            int num2 = index % 8;
            int num3 = 0;
            int num4 = 0;
            switch (num2)
            {
                case 0:
                    num3 += value ? 1 : 0;
                    num4 = 0xfe;
                    break;

                case 1:
                    num3 += value ? 2 : 0;
                    num4 = 0xfd;
                    break;

                case 2:
                    num3 += value ? 4 : 0;
                    num4 = 0xfb;
                    break;

                case 3:
                    num3 += value ? 8 : 0;
                    num4 = 0xf7;
                    break;

                case 4:
                    num3 += value ? 0x10 : 0;
                    num4 = 0xef;
                    break;

                case 5:
                    num3 += value ? 0x20 : 0;
                    num4 = 0xdf;
                    break;

                case 6:
                    num3 += value ? 0x40 : 0;
                    num4 = 0xbf;
                    break;

                case 7:
                    num3 += value ? 0x80 : 0;
                    num4 = 0x7f;
                    break;
            }
            data[40 + num] = (byte) (num3 + (data[40 + num] & num4));
        }

        private int ShortOfInt(int value)
        {
            if (value > 0xffff)
            {
                value = 0xffff;
            }
            else if (value < -65535)
            {
                value = -65535;
            }
            return value & 0xffff;
        }

        public int BaseExp
        {
            get
            {
                return data[0x22] + data[0x23] * 0x100;
            }
            set
            {
                data[0x22] = (byte) (ShortOfInt(value) & 0xff);
                data[0x23] = (byte) ((ShortOfInt(value) >> 8) & 0xff);
            }
        }

        public int Capture
        {
            get
            {
                return data[8];
            }
            set
            {
                data[8] = (byte) ByteOfInt(value);
            }
        }

        public byte[] Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public int Effort
        {
            get
            {
                return data[10] + data[11] * 0x100;
            }
            set
            {
                data[10] = (byte) (ShortOfInt(value) & 0xff);
                data[11] = (byte) ((ShortOfInt(value) >> 8) & 0xff);
            }
        }

        public int Effort1
        {
            get
            {
                return data[10];
            }
            set
            {
                data[10] = (byte) ByteOfInt(value);
            }
        }

        public int Effort2
        {
            get
            {
                return data[11];
            }
            set
            {
                data[11] = (byte) ByteOfInt(value);
            }
        }

        public int EffortAtk
        {
            get
            {
                return (data[10] >> 2) & 3;
            }
            set
            {
                int num = (ByteOfInt(value) & 3) << 2;
                int num2 = data[10] & 0xf3;
                data[10] = (byte) (num + num2);
            }
        }

        public int EffortDef
        {
            get
            {
                return (data[10] >> 4) & 3;
            }
            set
            {
                int num = (ByteOfInt(value) & 3) << 4;
                int num2 = data[10] & 0xcf;
                data[10] = (byte) (num + num2);
            }
        }

        public int EffortHp
        {
            get
            {
                return data[10] & 3;
            }
            set
            {
                int num = ByteOfInt(value) & 3;
                int num2 = data[10] & 0xfc;
                data[10] = (byte) (num + num2);
            }
        }

        public int EffortSatk
        {
            get
            {
                return data[11] & 3;
            }
            set
            {
                int num = ByteOfInt(value) & 3;
                int num2 = data[11] & 0xfc;
                data[11] = (byte) (num + num2);
            }
        }

        public int EffortSdef
        {
            get
            {
                return (data[11] >> 2) & 3;
            }
            set
            {
                int num = (ByteOfInt(value) & 3) << 2;
                int num2 = data[11] & 0xf3;
                data[11] = (byte) (num + num2);
            }
        }

        public int EffortSpd
        {
            get
            {
                return (data[10] >> 6) & 3;
            }
            set
            {
                int num = (ByteOfInt(value) & 3) << 6;
                int num2 = data[10] & 0x3f;
                data[10] = (byte) (num + num2);
            }
        }

        public int EggStep
        {
            get
            {
                return data[0x13];
            }
            set
            {
                data[0x13] = (byte) ByteOfInt(value);
            }
        }

        public int Escape
        {
            get
            {
                return data[0x1b];
            }
            set
            {
                data[0x1b] = (byte) ByteOfInt(value);
            }
        }

        public int ExpType
        {
            get
            {
                return data[0x15];
            }
            set
            {
                data[0x15] = (byte) ByteOfInt(value);
            }
        }

        public int FamilyAtk
        {
            get
            {
                return data[1];
            }
            set
            {
                data[1] = (byte) ByteOfInt(value);
            }
        }

        public int FamilyDef
        {
            get
            {
                return data[2];
            }
            set
            {
                data[2] = (byte) ByteOfInt(value);
            }
        }

        public int FamilyHp
        {
            get
            {
                return data[0];
            }
            set
            {
                data[0] = (byte) ByteOfInt(value);
            }
        }

        public int FamilySatk
        {
            get
            {
                return data[4];
            }
            set
            {
                data[4] = (byte) ByteOfInt(value);
            }
        }

        public int FamilySdef
        {
            get
            {
                return data[5];
            }
            set
            {
                data[5] = (byte) ByteOfInt(value);
            }
        }

        public int FamilySpd
        {
            get
            {
                return data[3];
            }
            set
            {
                data[3] = (byte) ByteOfInt(value);
            }
        }

        public int Feel
        {
            get
            {
                return data[20];
            }
            set
            {
                data[20] = (byte) ByteOfInt(value);
            }
        }

        public int Group1
        {
            get
            {
                return data[0x16];
            }
            set
            {
                data[0x16] = (byte) ByteOfInt(value);
            }
        }

        public int Group2
        {
            get
            {
                return data[0x17];
            }
            set
            {
                data[0x17] = (byte) ByteOfInt(value);
            }
        }

        public byte this[int i]
        {
            get
            {
                return data[i];
            }
            set
            {
                data[i] = value;
            }
        }

        public int Item1
        {
            get
            {
                return data[12] + data[13] * 0x100;
            }
            set
            {
                data[12] = (byte) (ShortOfInt(value) & 0xff);
                data[13] = (byte) ((ShortOfInt(value) >> 8) & 0xff);
            }
        }

        public int Item1A
        {
            get
            {
                return data[12];
            }
            set
            {
                data[12] = (byte) ByteOfInt(value);
            }
        }

        public int Item1B
        {
            get
            {
                return data[13];
            }
            set
            {
                data[13] = (byte) ByteOfInt(value);
            }
        }

        public int Item2
        {
            get
            {
                return data[14] + data[15] * 0x100;
            }
            set
            {
                data[14] = (byte) (ShortOfInt(value) & 0xff);
                data[15] = (byte) ((ShortOfInt(value) >> 8) & 0xff);
            }
        }

        public int Item2A
        {
            get
            {
                return data[14];
            }
            set
            {
                data[14] = (byte) ByteOfInt(value);
            }
        }

        public int Item2B
        {
            get
            {
                return data[15];
            }
            set
            {
                data[15] = (byte) ByteOfInt(value);
            }
        }

        public int Item3
        {
            get
            {
                return data[0x10] + data[0x11] * 0x100;
            }
            set
            {
                data[0x10] = (byte) (ShortOfInt(value) & 0xff);
                data[0x11] = (byte) ((ShortOfInt(value) >> 8) & 0xff);
            }
        }

        public int Item3A
        {
            get
            {
                return data[0x10];
            }
            set
            {
                data[0x10] = (byte) ByteOfInt(value);
            }
        }

        public int Item3B
        {
            get
            {
                return data[0x11];
            }
            set
            {
                data[0x11] = (byte) ByteOfInt(value);
            }
        }

        public int Length => data.Length;

        public int Look
        {
            get
            {
                return data[0x21];
            }
            set
            {
                data[0x21] = (byte) ByteOfInt(value);
            }
        }

        public int Rank
        {
            get
            {
                return data[9];
            }
            set
            {
                data[9] = (byte) ByteOfInt(value);
            }
        }

        public int Sex
        {
            get
            {
                return data[0x12];
            }
            set
            {
                data[0x12] = (byte) ByteOfInt(value);
            }
        }

        public int Specific1
        {
            get
            {
                return data[0x18];
            }
            set
            {
                data[0x18] = (byte) ByteOfInt(value);
            }
        }

        public int Specific2
        {
            get
            {
                return data[0x19];
            }
            set
            {
                data[0x19] = (byte) ByteOfInt(value);
            }
        }

        public int Specific3
        {
            get
            {
                return data[0x1a];
            }
            set
            {
                data[0x1a] = (byte) ByteOfInt(value);
            }
        }

        public int Type1
        {
            get
            {
                return data[6];
            }
            set
            {
                data[6] = (byte) ByteOfInt(value);
            }
        }

        public int Type2
        {
            get
            {
                return data[7];
            }
            set
            {
                data[7] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown1C
        {
            get
            {
                return data[0x1c];
            }
            set
            {
                data[0x1c] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown1D
        {
            get
            {
                return data[0x1d];
            }
            set
            {
                data[0x1d] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown1E
        {
            get
            {
                return data[30];
            }
            set
            {
                data[30] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown1F
        {
            get
            {
                return data[0x1f];
            }
            set
            {
                data[0x1f] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown20
        {
            get
            {
                return data[0x20];
            }
            set
            {
                data[0x20] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown24
        {
            get
            {
                return data[0x24];
            }
            set
            {
                data[0x24] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown25
        {
            get
            {
                return data[0x25];
            }
            set
            {
                data[0x25] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown26
        {
            get
            {
                return data[0x26];
            }
            set
            {
                data[0x26] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown27
        {
            get
            {
                return data[0x27];
            }
            set
            {
                data[0x27] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown35
        {
            get
            {
                return data[0x35];
            }
            set
            {
                data[0x35] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown36
        {
            get
            {
                return data[0x36];
            }
            set
            {
                data[0x36] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown37
        {
            get
            {
                return data[0x37];
            }
            set
            {
                data[0x37] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown38
        {
            get
            {
                return data[0x38];
            }
            set
            {
                data[0x38] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown39
        {
            get
            {
                return data[0x39];
            }
            set
            {
                data[0x39] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown3A
        {
            get
            {
                return data[0x3a];
            }
            set
            {
                data[0x3a] = (byte) ByteOfInt(value);
            }
        }

        public int Unkown3B
        {
            get
            {
                return data[0x3b];
            }
            set
            {
                data[0x3b] = (byte) ByteOfInt(value);
            }
        }
    }
}

