internal class binaryToDecimal
{
    static int BinaryCalculator(string binary)
    {
        int decimalCalculated = 0;
        int characterBackwardsRead = 1;

        for (int i = 0; characterBackwardsRead <= binary.Length; i++)
        {

            int getlastBinary = ((int)Char.GetNumericValue(binary[^characterBackwardsRead]));
            decimalCalculated += (int)(getlastBinary * (Math.Pow(2, i)));
            characterBackwardsRead++;

        }
        return decimalCalculated;
    }
}



