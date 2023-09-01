using System;

namespace ConsoleApp1
{
    class Program
    {
        static int toYear = 9999;
        static int fromYear = 1800;
        static bool isLeap(int year)
        {

            return (((year % 4 == 0) &&
                     (year % 100 != 0)) ||
                     (year % 400 == 0));
        }
        static bool isValidDate(int d, int m, int y)
        {
            if (y > toYear || y < fromYear)
                return false;
            if (m < 1 || m > 12)
                return false;
            if (d < 1 || d > 31)
                return false;
            if (m == 2)
            {
                if (isLeap(y))
                    return (d <= 29);
                else
                    return (d <= 28);
            }
            if (m == 4 || m == 6 || m == 9 || m == 11)
                return (d <= 30);

            return true;
        }
        private static void Main(string[] args)
        {
            int fromYear = 2010, toYear = 2015;

            printBonusDatesBetween(fromYear, toYear);
        }
        static void printBonusDatesBetween(int fromYear, int toYear)
        {
            for (int year = fromYear; year <= toYear; year++)
            {

                String str = String.Join("", year);
                String rev = str;
                rev = reverse(rev);


                int day = Int32.Parse(rev.Substring(0, 2));
                int month = Int32.Parse(rev.Substring(2, 2));


                if (isValidDate(day, month, year))
                {
                    Console.WriteLine(rev + str + "\n");
                }
                static String reverse(String input)
                {
                    char[] a = input.ToCharArray();
                    int l, r = a.Length - 1;
                    for (l = 0; l < r; l++, r--)
                    {
                        char temp = a[l];
                        a[l] = a[r];
                        a[r] = temp;
                    }
                    return String.Join("", a);
                }
            }
        }
    }
}
