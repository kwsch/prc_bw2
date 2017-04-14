namespace POKEMON_BW2
{
    public class SkillData
    {
        private byte[] data = new byte[0x24];
        public const int FCOUNT = 3;
        public const int SIZE = 0x24;

        public int GetFluctuationProbability(int index)
        {
            return data[0x1b + index];
        }

        public int GetFluctuationStatus(int index)
        {
            return data[0x15 + index];
        }

        public int GetFluctuationValue(int index)
        {
            return BT.Convert.ToSbyte(data[0x18 + index]);
        }

        public void SetFluctuationProbability(int index, int value)
        {
            data[0x1b + index] = (byte) value;
        }

        public void SetFluctuationStatus(int index, int value)
        {
            data[0x15 + index] = (byte) value;
        }

        public void SetFluctuationValue(int index, int value)
        {
            data[0x18 + index] = (byte) value;
        }

        public int Assort
        {
            get
            {
                return data[2];
            }
            set
            {
                data[2] = (byte) value;
            }
        }

        public int Category
        {
            get
            {
                return data[1];
            }
            set
            {
                data[1] = (byte) value;
            }
        }

        public int ConditionCode
        {
            get
            {
                return data[8] + data[9] * 0x100;
            }
            set
            {
                data[8] = (byte) (value & 0xff);
                data[9] = (byte) ((value >> 8) & 0xff);
            }
        }

        public int ConditionProbability
        {
            get
            {
                return data[10];
            }
            set
            {
                data[10] = (byte) value;
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

        public int EffectCode
        {
            get
            {
                return data[0x10] + data[0x11] * 0x100;
            }
            set
            {
                data[0x10] = (byte) (value & 0xff);
                data[0x11] = (byte) ((value >> 8) & 0xff);
            }
        }

        public int Fatal
        {
            get
            {
                return data[14];
            }
            set
            {
                data[14] = (byte) value;
            }
        }

        public int FluctuationByDamage
        {
            get
            {
                return BT.Convert.ToSbyte(data[0x12]);
            }
            set
            {
                data[0x12] = (byte) value;
            }
        }

        public int FluctuationByHP
        {
            get
            {
                return BT.Convert.ToSbyte(data[0x13]);
            }
            set
            {
                data[0x13] = (byte) value;
            }
        }

        public int Hit
        {
            get
            {
                return data[4];
            }
            set
            {
                data[4] = (byte) value;
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

        public int Length => data.Length;

        public int MaxRepeat
        {
            get
            {
                return data[7] / 0x10;
            }
            set
            {
                data[7] = (byte) ((data[7] & 15) + value * 0x10);
            }
        }

        public int MaxTurn
        {
            get
            {
                return data[13];
            }
            set
            {
                data[13] = (byte) value;
            }
        }

        public int MinRepeat
        {
            get
            {
                return data[7] % 0x10;
            }
            set
            {
                data[7] = (byte) ((data[7] & 240) + value);
            }
        }

        public int MinTurn
        {
            get
            {
                return data[12];
            }
            set
            {
                data[12] = (byte) value;
            }
        }

        public int Power
        {
            get
            {
                return data[3];
            }
            set
            {
                data[3] = (byte) value;
            }
        }

        public int PP
        {
            get
            {
                return data[5];
            }
            set
            {
                data[5] = (byte) value;
            }
        }

        public int Priority
        {
            get
            {
                return BT.Convert.ToSbyte(data[6]);
            }
            set
            {
                data[6] = (byte) value;
            }
        }

        public int Target
        {
            get
            {
                return data[20];
            }
            set
            {
                data[20] = (byte) value;
            }
        }

        public int Type
        {
            get
            {
                return data[0];
            }
            set
            {
                data[0] = (byte) value;
            }
        }

        public int Unkown0B
        {
            get
            {
                return data[11];
            }
            set
            {
                data[11] = (byte) value;
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
                data[30] = (byte) value;
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
                data[0x1f] = (byte) value;
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
                data[0x20] = (byte) value;
            }
        }

        public int Unkown21
        {
            get
            {
                return data[0x21];
            }
            set
            {
                data[0x21] = (byte) value;
            }
        }

        public int Wince
        {
            get
            {
                return data[15];
            }
            set
            {
                data[15] = (byte) value;
            }
        }
    }
}

