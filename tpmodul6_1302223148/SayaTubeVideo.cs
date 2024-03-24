using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace tpmodul6_1302223148
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            if (title != null && title.Length <= 100)
            {
                this.id = random.Next(10000, 99999);
                this.title = title;
                this.playCount = 0;
            }
            else
            {
                this.id = random.Next(10000, 99999);
                this.title = "Default";
                this.playCount = 0;
            }
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 10000000)
            {
                try
                {
                    checked
                    {
                        this.playCount++;
                    }
                }

                catch(OverflowException)
                {
                    Console.WriteLine("Overflow.");
                }
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
