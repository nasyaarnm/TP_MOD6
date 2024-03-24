// See https://aka.ms/new-console-template for more information

using System;
using tpmodul6_1302223148;


public class Program()
{
    public static void Main (String[] args)
    {
        SayaTubeVideo nama = new SayaTubeVideo("Tutorial Design by Contract-{NASYA_KIRANA_MARENDRA}");
        nama.IncreasePlayCount(1000000);
        nama.printVideoDetails();

    }
}