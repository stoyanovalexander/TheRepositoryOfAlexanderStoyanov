using System;
    class CardsNames
    {
        static void Main()
        {
            string nameOfCardText="4";
            for (byte nameOfCard = 2; nameOfCard <= 14; nameOfCard++)
            {
                switch (nameOfCard)
                { 
                    case 2:
                        nameOfCardText = "Two";break;
                    case 3:
                        nameOfCardText = "Three";break;
                    case 4:
                        nameOfCardText = "Four";break;
                    case 5:
                        nameOfCardText = "Five";break;
                    case 6:
                        nameOfCardText = "Six";break;
                    case 7:
                        nameOfCardText = "Seven";break;
                    case 8:
                        nameOfCardText = "Eight";break;
                    case 9:
                        nameOfCardText = "Nine";break;
                    case 10:
                        nameOfCardText = "Ten";break;
                    case 11:
                        nameOfCardText = "Jack";break;
                    case 12:
                        nameOfCardText = "Queen";break;
                    case 13:
                        nameOfCardText = "King";break;
                    case 14:
                        nameOfCardText = "Ace";break;
                }
                for (byte colorOfCard = 1; colorOfCard <= 4; colorOfCard++)
                {
                    switch (colorOfCard)
                    { 
                        case 1:
                            Console.WriteLine("{0} of club",nameOfCardText);break;
                        case 2:
                            Console.WriteLine("{0} of diamond",nameOfCardText); break;
                        case 3:
                            Console.WriteLine("{0} of heart",nameOfCardText); break;
                        case 4:
                            Console.WriteLine("{0} of spade",nameOfCardText); break;
                    }
                }
            }
        }
    }

