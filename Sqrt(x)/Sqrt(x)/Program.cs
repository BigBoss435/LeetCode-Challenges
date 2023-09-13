
/*Given a non-negative integer x, return the square root of x rounded down to the nearest integer.
The returned integer should be non-negative as well.
You must not use any built-in exponent function or operator.*/

public class Program
{
    public int MySqrt(int x)
    {
        if (x < 2)
        {
            return x;
        }

        double y = x;
        double z = (y + (x / y)) / 2;

        while (Math.Abs(y - z) >= 0.00001)
        {
            y = z;
            z = (y + (x / y)) / 2;
        }
        return (int)z;
    }
}