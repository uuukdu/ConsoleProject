using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(40, 40);
            Player player = new Player(40, 40);

            while (true)
            {
                map.PrintMap();
                player.PrintPlayer();

                Thread.Sleep(10000);
            }
        }
    }
}
