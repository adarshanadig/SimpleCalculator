namespace SimpleCalculator;

public class Calculator
{

    public double Add(double firstNumber,double secondNumber)
    {
        try
        {
            return firstNumber + secondNumber+1;  
        }
        catch(Exception ex)
        {
            return -1;
        }

        return -1;
    }
}

