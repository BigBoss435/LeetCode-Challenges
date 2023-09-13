
/*Given an integer n, return true if it is a power of two. Otherwise, return false.
An integer n is a power of two, if there exists an integer x such that n == 2x.*/

public class Program
{
    public bool IsPowerOfTwo(int n)
    {
        int division = n;
        while (true)
        {
            if (n == 1 || n == 2)
            {
                return true;
            }
            else if (division % 2 != 0)
            {
                return false;
            }
            else if (division % 2 == 0)
            {
                while (division % 2 == 0)
                {
                    division /= 2;
                    if (division == 2)
                    {
                        return true;
                    }
                    else if (division < 2)
                    {
                        return false;
                    }
                }
            }
        }
    }
}