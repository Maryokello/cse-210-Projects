// Fraction.cs

public class Fraction
{
    // Private attributes
    private int _numerator;
    private int _denominator;

    // Constructor with no parameters: initializes to 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with one parameter: numerator, denominator = 1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor with two parameters: numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator != 0 ? denominator : 1; // Prevent division by zero
    }

    // Getter and setter for numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int value)
    {
        _numerator = value;
    }

    // Getter and setter for denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int value)
    {
        if (value != 0)
        {
            _denominator = value;
        }
    }

    // Method to return the fraction string representation
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
