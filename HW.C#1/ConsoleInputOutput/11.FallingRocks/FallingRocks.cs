using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
    class FallingRocks
    {
        static int dwarfPosition = 3;
        static int result = 0;
        static Random randomGenerator = new Random();
        static char[,] rocksCreate = new char[Console.WindowWidth, Console.WindowHeight];

        static void RemoveScrollBars()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;  
        }

        static void DrawDwarf()
        {
            PrintAtPosition(dwarfPosition - 1, Console.WindowHeight-1, '(');
            PrintAtPosition(dwarfPosition, Console.WindowHeight-1, '0');
            PrintAtPosition(dwarfPosition + 1, Console.WindowHeight-1, ')');
        }

        static void PrintAtPosition(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        static void SetInitialPosition()
        {
            dwarfPosition = Console.WindowWidth / 2;
        }

        static void MoveDwarfLeft()
        {
            if(dwarfPosition>=2)
            {
                dwarfPosition--;
            }
        }

        static void MoveDwarfRight()
        {
            if(dwarfPosition<=Console.WindowWidth-1-2)
            {
                dwarfPosition++;
            }
        }

        static void RocksCreate()
        {
            for(int x=0;x<Console.WindowWidth;x++)
            {
                int rockNumber=randomGenerator.Next(1,500);
                switch(rockNumber)
                {
                    case 1: rocksCreate[x,1]='%';break;
                    case 2: rocksCreate[x,1]='(';break;
                    case 3: rocksCreate[x,1]='^';break;
                    case 4: rocksCreate[x,1]='&';break;
                    case 5: rocksCreate[x,1]=')';break;
                    case 6: rocksCreate[x,1]='!';break;
                    case 7: rocksCreate[x,1]='*';break;
                    case 8: rocksCreate[x,1]='@';break;
                    case 9: rocksCreate[x,1]='#';break;
                    case 10: rocksCreate[x,1]='=';break;
                    default: rocksCreate[x,1]=' ';break;
                }
            }
        }

        static void MoveRocksDawn()
        {
            for(int y=Console.WindowHeight-1;y>=2;y--)
            {
                for(int x=0;x<Console.WindowWidth;x++)
                {
                    rocksCreate[x,y]=rocksCreate[x,y-1];
                }
            }
            for(int x=0;x<Console.WindowWidth;x++)
            {
                if(((x<=dwarfPosition+1)&&(x>=dwarfPosition-1))&&((rocksCreate[x,Console.WindowHeight-1]=='%')||(rocksCreate[x,Console.WindowHeight-1]=='(')||(rocksCreate[x,Console.WindowHeight-1]=='^')||(rocksCreate[x,Console.WindowHeight-1]=='&')||(rocksCreate[x,Console.WindowHeight-1]==')')||(rocksCreate[x,Console.WindowHeight-1]=='!')||(rocksCreate[x,Console.WindowHeight-1]=='*')||(rocksCreate[x,Console.WindowHeight-1]=='@')||(rocksCreate[x,Console.WindowHeight-1]=='#')||(rocksCreate[x,Console.WindowHeight-1]=='=')))
                {
                    Console.Clear();
                    Console.WriteLine("Game Over  result="+result);
                    Console.ReadKey();
                }
                else if (((x > dwarfPosition + 1) || (x < dwarfPosition - 1)) && ((rocksCreate[x, Console.WindowHeight - 1] == '%') || (rocksCreate[x, Console.WindowHeight - 1] == '(') || (rocksCreate[x, Console.WindowHeight - 1] == '^') || (rocksCreate[x, Console.WindowHeight - 1] == '&') || (rocksCreate[x, Console.WindowHeight - 1] == ')') || (rocksCreate[x, Console.WindowHeight - 1] == '!') || (rocksCreate[x, Console.WindowHeight - 1] == '*') || (rocksCreate[x, Console.WindowHeight - 1] == '@') || (rocksCreate[x, Console.WindowHeight - 1] == '#') || (rocksCreate[x, Console.WindowHeight - 1] == '=')))
                {
                    result=result+1;
                }
            }
        }

        static void DrawRocks()
        {
            for (int y = 1; y < Console.WindowHeight; y++)
            {
                for (int x = 0; x < Console.WindowWidth; x++)
                {
                    if (rocksCreate[x, y] != ' ')
                    {
                        PrintAtPosition(x, y, rocksCreate[x, y]);
                    }
                }
            }
        }
       
        static void Main()
        {
            RemoveScrollBars();
            SetInitialPosition();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.LeftArrow)
                    {
                        MoveDwarfLeft();
                    }
                    if (keyInfo.Key == ConsoleKey.RightArrow)
                    {
                        MoveDwarfRight();
                    }
                }
                
                RocksCreate();
                MoveRocksDawn();
                Console.Clear();
                DrawDwarf();
                DrawRocks();
                Thread.Sleep(50);
            }
        }
    }

