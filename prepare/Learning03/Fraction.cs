 
class Fraction
{
    //private top and bottom attributes
        private int _numerator;
        private int _denominator;

        public Fraction() //Constructor with no parameters to initialize the numbers to 1/1
        {
            _numerator = 1;
            _denominator = 1;
        }

        public Fraction(int intNumber)  //Constructor with one top parameter that initializes the denominator to 1
        {
            _numerator = intNumber;
            _denominator = 1;

        }

        // Constructor with top and bottom parameters
        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public int GetNumerator()  // Numerator getter
        {
            return _numerator;
        }

        public void SetNumerator(int numerator)  //Numerator setter
        {
            _numerator = numerator;
        }

        public int GetDenominator()  // Denominator getter
        {
            return _denominator;
        }

        public void SetDenominator(int denominator)  // Denominator setter
        {
            _denominator = denominator;
        }

        public string GetFractionString()  // Method that returns the fraction
        {
            string fractext = $"{_numerator}/{_denominator}";

            return fractext;
        }

        // Method that returns a double, the result of dividing the top number by the bottom number
        public double GetDecimalValue()  
        {
            return (double)_numerator/(double)_denominator;
        }
}