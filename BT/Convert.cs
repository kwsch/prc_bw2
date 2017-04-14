using System;

namespace BT
{
    public static class Convert
    {
        private const string DIGIT_ERROR_MESSAGE = "Digit must be 2,8,10 or 16.";

        public static int Adjust(int value, int max, int min) // clamp
        {
            if (value > max)
            {
                return max;
            }
            if (value < min)
            {
                return min;
            }
            return value;
        }

        public static int ToInt(string value, int digit)
        {
            if ((digit != 0x10) && (digit != 10) && (digit != 8) && (digit != 2))
            {
                throw new ArgumentException("Digit must be 2,8,10 or 16.");
            }
            try
            {
                return System.Convert.ToInt32(value, digit);
            }
            catch (OverflowException)
            {
                return 0x7fffffff;
            }
            catch
            {
                return 0;
            }
        }

        public static int ToInt(string value, int digit, int max, int min)
        {
            return Adjust(ToInt(value, digit), max, min);
        }

        public static int ToSbyte(byte value)
        {
            return ToSbyte((int) value);
        }

        public static int ToSbyte(int value)
        {
            int num = 0;
            value &= 0xff;
            if (value < 0x80)
            {
                return value;
            }
            return num - (0x100 - value);
        }

        public static string ToString(int value, int digit)
        {
            if ((digit != 0x10) && (digit != 10) && (digit != 8) && (digit != 2))
            {
                throw new ArgumentException("Digit must be 2,8,10 or 16.");
            }
            return System.Convert.ToString(value, digit).ToUpper();
        }

        public static string ToString(int value, int digit, int max, int min)
        {
            if ((digit != 0x10) && (digit != 10) && (digit != 8) && (digit != 2))
            {
                throw new ArgumentException("Digit must be 2,8,10 or 16.");
            }
            return System.Convert.ToString(Adjust(value, max, min), digit).ToUpper();
        }
    }
}

