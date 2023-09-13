
/*Given an integer n, return true if it is a power of three. Otherwise, return false.
An integer n is a power of three, if there exists an integer x such that n == 3x.*/

public class Program
{
    public bool IsPowerOfThree(int n)
    {
        int division = n;
        while (true)
        {
            if (n == 1 || n == 3)
            {
                return true;
            }
            else if (division % 3 != 0)
            {
                return false;
            }
            else if (division % 3 == 0)
            {
                while (division % 3 == 0)
                {
                    division /= 3;
                    if (division == 3)
                    {
                        return true;
                    }
                    else if (division < 3)
                    {
                        return false;
                    }
                }
            }
        }
    }
}