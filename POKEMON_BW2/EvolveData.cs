namespace POKEMON_BW2
{
    public class EvolveData
    {
        private byte[] data = new byte[0x2c];
        public const int ECOUNT = 7;
        public const int SIZE = 0x2c;

        public int GetCode(int index)
        {
            return data[6 * index] + data[6 * index + 1] * 0x100;
        }

        public int GetPokemon(int index)
        {
            return data[6 * index + 4] + data[6 * index + 5] * 0x100;
        }

        public int GetValue(int index)
        {
            return data[6 * index + 2] + data[6 * index + 3] * 0x100;
        }

        public void SetCode(int index, int value)
        {
            data[index * 6] = (byte) (value & 0xff);
            data[index * 6 + 1] = (byte) ((value >> 8) & 0xff);
        }

        public void SetPokemon(int index, int value)
        {
            data[index * 6 + 4] = (byte) (value & 0xff);
            data[index * 6 + 5] = (byte) ((value >> 8) & 0xff);
        }

        public void SetValue(int index, int value)
        {
            data[index * 6 + 2] = (byte) (value & 0xff);
            data[index * 6 + 3] = (byte) ((value >> 8) & 0xff);
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

        public int Length => data.Length;
    }
}

