namespace POKEMON_BW2
{

    public class PlaceData
    {
        private byte[] data = new byte[0xe8];
        public const int PCOUNT = 0x38;
        public const int SIZE = 0xe8;

        public int GetMaxLv(int index)
        {
            return data[8 + index * 4 + 3];
        }

        public int GetMinLv(int index)
        {
            return data[8 + index * 4 + 2];
        }

        public int GetPokemon(int index)
        {
            return data[8 + index * 4] + data[8 + index * 4 + 1] * 0x100;
        }

        public void SetMaxLv(int index, int value)
        {
            data[8 + index * 4 + 3] = (byte) value;
        }

        public void SetMinLv(int index, int value)
        {
            data[8 + index * 4 + 2] = (byte) value;
        }

        public void SetPokemon(int index, int value)
        {
            data[8 + index * 4] = (byte) (value & 0xff);
            data[8 + index * 4 + 1] = (byte) ((value >> 8) & 0xff);
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

        public int Length
        {
            get
            {
                return data.Length;
            }
        }
    }
}

