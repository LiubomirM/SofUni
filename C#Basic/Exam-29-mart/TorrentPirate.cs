using System;

class TorrentPirate
{
    static void Main()
    {
        double d = int.Parse(Console.ReadLine());
        double p = int.Parse(Console.ReadLine());
        double w = int.Parse(Console.ReadLine());
        double downloadTime = d / 2 / 60 / 60;
        double priceForDownload = downloadTime * w;
        double numbersOfMovie = d / 1500;
        double cinemaPrice = numbersOfMovie * p;
        if (priceForDownload > cinemaPrice)
        {
            Console.WriteLine("cinema -> {0:0.00}lv", cinemaPrice);
        }
        else
        {
            Console.WriteLine("mall -> {0:0.00}lv", priceForDownload);
        }
    }
}

