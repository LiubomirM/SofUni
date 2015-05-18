using System;

class MagicDates
{
    static void Main()
    {
        int startyear = int.Parse(Console.ReadLine());
        int endyear = int.Parse(Console.ReadLine());
        int magic = int.Parse(Console.ReadLine());
        bool hasAnswer = false;
        int tempmagic;
        string date;

        for (int year = startyear; year <= endyear; year++)
        {
            for (int mount = 1; mount <= 12; mount++)
            {
                for (int day = 1; day <= 31; day++)
                {
                    tempmagic = 0;
                    if ((!DateTime.IsLeapYear(year) && mount == 2 && day > 28) ||
                        (DateTime.IsLeapYear(year) && mount == 2 && day > 29) ||
                        (day == 31 && (mount == 4 || mount == 6 || mount == 9 || mount == 11)))
                    {
                        continue;
                    }
                    else
                    {
                        date = day.ToString() + mount + year;
                        for (int i = 0; i < date.Length; i++)
                        {
                            int a = int.Parse(date[i].ToString());
                            for (int j = i + 1; j < date.Length; j++)
                            {
                                int b = int.Parse(date[j].ToString());
                                tempmagic += a * b;
                            }
                        }
                        if (tempmagic == magic)
                        {
                            DateTime printdate = new DateTime(year, mount, day);
                            Console.WriteLine(printdate.ToString("dd-MM-yyyy"));
                            hasAnswer = true;
                        }
                    }
                }
            }
        }
        if (!hasAnswer)
        {
            Console.WriteLine("No");
        }
    }
}
