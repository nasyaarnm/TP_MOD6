// See https://aka.ms/new-console-template for more information

using System;
using tpmodul6_1302223148;


public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo nama = new SayaTubeVideo("Tutorial Design by Contract-{NASYA_KIRANA_MARENDRA}");
        nama.IncreasePlayCount(10000000); 
        for (int i = 0; i < 10000; i++)
        {
            nama.IncreasePlayCount(1000000);
        }
        nama.PrintVideoDetails(); 
    }
}