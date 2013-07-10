using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03.Poker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string[] cards = new string[13];
            //cards[0] = "2";
            //cards[1] = "3";
            //cards[2] = "4";
            //cards[3] = "5";
            //cards[4] = "6";
            //cards[5] = "7";
            //cards[6] = "8";
            //cards[7] = "9";
            //cards[8] = "10";
            //cards[9] = "J";
            //cards[10] = "Q";
            //cards[11] = "K";
            //cards[12] = "A";

            //string two = "2";
            //string three = "3";
            //string four = "4";
            //string five = "5";
            //string six = "6";
            //string seven = "7";
            //string eight = "8";
            //string nine = "9";
            //string ten = "10";
            //string jack = "J";
            //string queen = "Q";
            //string king = "K";
            //string as = "A";
          
            int[] num = new int[5];


            for (int i = 0; i <= 4; i++)
            {
                string card = Console.ReadLine();
                int help = 0;
                if (card == "2") help = 2;
                if (card == "3") help = 3;
                if (card == "4") help = 4;
                if (card == "5") help = 5;
                if (card == "6") help = 6;
                if (card == "7") help = 7;
                if (card == "8") help = 8;
                if (card == "9") help = 9;
                if (card == "10") help = 10;
                if (card == "J") help = 11;
                if (card == "Q") help = 12;
                if (card == "K") help = 13;
                if (card == "A") help = 14;


                switch(help)
                {
                    case 2:
                        num[i]=0;break;
                    case 3:
                        num[i] = 1;break;
                    case 4:
                        num[i] = 2; break;
                    case 5:
                        num[i] = 3; break;
                    case 6:
                        num[i] = 4; break;
                    case 7:
                        num[i] = 5; break;
                    case 8:
                        num[i] = 6; break;
                    case 9:
                        num[i] = 7; break;
                    case 10:
                        num[i] = 8; break;
                    case 11:
                        num[i] = 9; break;
                    case 12:
                        num[i] = 10; break;
                    case 13:
                        num[i] = 11; break;
                    case 14:
                        num[i] = 12; break;
                }
            }


            for (int i = 0; i <= 3; i++)
            { 
                for(int j=i+1;j<=4;j++)
                {
                    if(num[i]>num[j])
                    {
                        int change=num[j];
                        num[j]=num[i];
                        num[i]=change;
                    }
                }
            }


            if((num[0]==num[1])&&(num[0]==num[2])&&(num[0]==num[3])&&(num[0]==num[4])) Console.WriteLine("Impossible");
            else if(((num[0]==num[1])&&(num[0]==num[2])&&(num[0]==num[3]))||((num[1]==num[2])&&(num[1]==num[3])&&(num[1]==num[4])))
            {
                Console.WriteLine("Four of a Kind");
            }
            else if((((num[0]==num[1])&&(num[0]==num[2]))&&(num[3]==num[4]))||
                ((num[0]==num[1])&&((num[2]==num[3])&&(num[2]==num[4]))))
            {
                Console.WriteLine("Full House");
            }
            else if(((num[0]+1==num[1])&&(num[1]+1==num[2])&&(num[2]+1==num[3])&&(num[3]+1==num[4]))||
                ((num[0]==0)&&(num[1]==1)&&(num[2]==2)&&(num[3]==3)&&(num[4]==12)))
            {
                Console.WriteLine("Straight");
            }
            else if(((num[0]==num[1])&&(num[0]==num[2]))||
                ((num[1]==num[2])&&(num[1]==num[3]))||
                ((num[2]==num[3])&&(num[2]==num[4])))
            {
                Console.WriteLine("Three of Kind");
            }
            else if(  ((num[0]==num[1])&&((num[2]==num[3])||(num[3]==num[4]))||
                ((num[1]==num[2])&&(num[3]==num[4]))))
            {
                Console.WriteLine("Two Pairs");
            }
            else if((num[0]==num[1])||(num[1]==num[2])||(num[2]==num[3])||(num[3]==num[4]))
            {
                Console.WriteLine("One Pair");
            }
            else
            {
                Console.WriteLine("Nothing");
            }
        }
    }
}
