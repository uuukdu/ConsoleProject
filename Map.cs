using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum BlockType
    {
        Empty,
        Wall,
        Stone,
        Iron,
        Gold,
        Diamond
    }
    internal class Map
    {
        BlockType[,] _map;
        private Random _random = new Random();

        public Map(int row, int col)
        {
            _map = new BlockType[row, col];

            for (int y = 0; y < _map.GetLength(0); y++)
            {
                for (int x = 0; x < _map.GetLength(1); x++)
                {
                    if (y == 0 || y == _map.GetLength(0) - 1 || x == 0 || x == _map.GetLength(1) - 1)
                    {
                        _map[y, x] = BlockType.Wall;
                    }
                    else
                    {
                        int rand = _random.Next(0, 100);

                        if (rand < 5)                 
                        {
                            _map[y, x] = BlockType.Diamond;
                        }
                        else if(rand < 10)
                        {
                            _map[y, x] = BlockType.Gold;
                        }
                        else if(rand < 20)
                        {
                            _map[y, x] = BlockType.Iron;
                        }
                        else if(rand < 100)
                        {
                            _map[y, x] = BlockType.Stone;
                        }
                    }
                }
            }
        }
        public void PrintMap()
        {
            Console.Clear();
            for (int y = 0; y < _map.GetLength(0); y++)
            {
                for (int x = 0; x < _map.GetLength(1); x++)
                {
                    switch (_map[y, x])
                    {
                        case BlockType.Empty:
                            Console.Write(" ");
                            break;
                        case BlockType.Wall:
                            Console.Write("■");
                            break;
                        case BlockType.Stone:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write("▧");
                            Console.ResetColor();
                            break;
                        case BlockType.Iron:
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("▧");
                            Console.ResetColor();
                            break;
                        case BlockType.Gold:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("▧");
                            Console.ResetColor();
                            break;
                        case BlockType.Diamond:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.OutputEncoding = Encoding.UTF8;
                            Console.Write("💎");
                            Console.ResetColor();
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}