
public class Program
{
    public bool isPowerOfFour(int n)
    {
        int division = n;
        while (true)
        {
            if (n == 1 || n == 4)
            {
                return true;
            }
            else if (division % 4 != 0)
            {
                return false;
            }
            else if (division % 4 == 0)
            {
                while (division % 4 == 0)
                {
                    division /= 4;
                    if (division == 4)
                    {
                        return true;
                    }
                    else if (division < 4)
                    {
                        return false;
                    }
                }
            }
        }
    }
}