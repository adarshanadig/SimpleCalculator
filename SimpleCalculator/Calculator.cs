namespace SimpleCalculator;

public class Calculator
{

    public double Add(double firstNumber,double secondNumber)
    {
        try
        {
            return firstNumber + secondNumber;  
        }
        catch(Exception ex)
        {
            return -1;
        }

        return -1;
    }
}

