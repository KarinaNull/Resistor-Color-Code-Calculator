namespace Resistor_Color_Code_Calculator
{
    public class UnitHelper
    {
        public static string TruncateZeroes(long number)
        {
               if (number.ToString().EndsWith("000000000"))
                return number.ToString().Substring(0, number.ToString().Length - 9) + 'G';
            else if (number.ToString().EndsWith("000000"))
                return number.ToString().Substring(0, number.ToString().Length - 6) + 'M';
            else if (number.ToString().EndsWith("000"))
                return number.ToString().Substring(0, number.ToString().Length - 3) + 'K';
            

            return number.ToString();
        }
    }
}
