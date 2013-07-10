using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Durankulak
    {
        static void Main()
        {
            string duranNum = Console.ReadLine();
            StringBuilder separated = new StringBuilder();
            int position=0;
            while (position < duranNum.Length)
            {
                if (char.IsUpper(duranNum[position]))
                {
                    separated.Append(duranNum[position]);
                    separated.Append(" ");
                }

                if (char.IsLower(duranNum[position]))
                {
                    separated.Append(duranNum[position]);
                    separated.Append(duranNum[position+1]);
                    separated.Append(" ");
                    position++;
                }
                position++;
            }
            string withSpaces = separated.ToString();
            withSpaces = withSpaces.Trim();
            string[] duranDigits = withSpaces.Split(' ');
            //for (int i = 0; i < duranDigits.Length; i++)
            //{
              //  Console.WriteLine(duranDigits[i]);
            //}

            long sum=0;
            for (int i = duranDigits.Length - 1; i >= 0; i--)
            {
                switch (duranDigits[i])
                { 
                    case "A":
                        sum = sum + 0 * (long)Math.Pow(168.0,(duranDigits.Length - 1 - i));break;
                    case "B":
                        sum = sum + 1 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "C":
                        sum = sum + 2* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "D":
                        sum = sum + 3 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "E":
                        sum = sum + 4 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "F":
                        sum = sum + 5 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "G":
                        sum = sum + 6 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "H":
                        sum = sum + 7 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "I":
                        sum = sum + 8 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "J":
                        sum = sum + 9 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "K":
                        sum = sum + 10 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "L":
                        sum = sum + 11* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "M":
                        sum = sum + 12* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "N":
                        sum = sum + 13* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "O":
                        sum = sum + 14* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "P":
                        sum = sum + 15* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "Q":
                        sum = sum + 16* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "R":
                        sum = sum + 17* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "S":
                        sum = sum + 18* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "T":
                        sum = sum + 19* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "U":
                        sum = sum + 20* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "V":
                        sum = sum + 21* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "W":
                        sum = sum + 22* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "X":
                        sum = sum + 23* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "Y":
                        sum = sum + 24* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "Z":
                        sum = sum + 25* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;


                    case "aA":
                        sum = sum + 26 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aB":
                        sum = sum + 27* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aC":
                        sum = sum + 28 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aD":
                        sum = sum + 29* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aE":
                        sum = sum + 30* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aF":
                        sum = sum + 31* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aG":
                        sum = sum + 32* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aH":
                        sum = sum + 33* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aI":
                        sum = sum + 34* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aJ":
                        sum = sum + 35* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aK":
                        sum = sum + 36 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aL":
                        sum = sum + 37 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aM":
                        sum = sum + 38 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aN":
                        sum = sum + 39 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aO":
                        sum = sum + 40 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aP":
                        sum = sum + 41 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aQ":
                        sum = sum + 42 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aR":
                        sum = sum + 43 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aS":
                        sum = sum + 44 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aT":
                        sum = sum + 45 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aU":
                        sum = sum + 46 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aV":
                        sum = sum + 47 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aW":
                        sum = sum + 48 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aX":
                        sum = sum + 49 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aY":
                        sum = sum + 50 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "aZ":
                        sum = sum + 51 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;


                    case "bA":
                        sum = sum + 52 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bB":
                        sum = sum + 53* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bC":
                        sum = sum + 54 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bD":
                        sum = sum + 55* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bE":
                        sum = sum + 56* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bF":
                        sum = sum + 57* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bG":
                        sum = sum + 58* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bH":
                        sum = sum + 59* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bI":
                        sum = sum + 60* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bJ":
                        sum = sum + 61* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bK":
                        sum = sum + 62 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bL":
                        sum = sum + 63 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bM":
                        sum = sum + 64 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bN":
                        sum = sum + 65 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bO":
                        sum = sum + 66 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bP":
                        sum = sum + 67 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bQ":
                        sum = sum + 68 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bR":
                        sum = sum + 69 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bS":
                        sum = sum + 70 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bT":
                        sum = sum + 71 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bU":
                        sum = sum + 72 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bV":
                        sum = sum + 73 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bW":
                        sum = sum + 74 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bX":
                        sum = sum + 75 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bY":
                        sum = sum + 76 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "bZ":
                        sum = sum + 77 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;

                        case "cA":
                        sum = sum + 78 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cB":
                        sum = sum + 79* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cC":
                        sum = sum + 80 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cD":
                        sum = sum + 81* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cE":
                        sum = sum + 82* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cF":
                        sum = sum + 83* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cG":
                        sum = sum + 84* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cH":
                        sum = sum + 85* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cI":
                        sum = sum + 86* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cJ":
                        sum = sum + 87* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cK":
                        sum = sum + 88 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cL":
                        sum = sum + 89 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cM":
                        sum = sum + 90 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cN":
                        sum = sum + 91 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cO":
                        sum = sum + 92 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cP":
                        sum = sum + 93 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cQ":
                        sum = sum + 94 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cR":
                        sum = sum + 95 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cS":
                        sum = sum + 96 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cT":
                        sum = sum + 97 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cU":
                        sum = sum + 98 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cV":
                        sum = sum + 99 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cW":
                        sum = sum + 100 * (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cX":
                        sum = sum + 101* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cY":
                        sum = sum + 102* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "cZ":
                        sum = sum + 103* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;


                    case "dA":
                        sum = sum + 104* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dB":
                        sum = sum + 105* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dC":
                        sum = sum + 106* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dD":
                        sum = sum + 107* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dE":
                        sum = sum + 108* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dF":
                        sum = sum + 109* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dG":
                        sum = sum + 110* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dH":
                        sum = sum + 111* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dI":
                        sum = sum + 112* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dJ":
                        sum = sum + 113* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dK":
                        sum = sum + 114* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dL":
                        sum = sum + 115* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dM":
                        sum = sum + 116* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dN":
                        sum = sum + 117* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dO":
                        sum = sum + 118* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dP":
                        sum = sum + 119* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dQ":
                        sum = sum + 120* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dR":
                        sum = sum + 121* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dS":
                        sum = sum + 122* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dT":
                        sum = sum + 123* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dU":
                        sum = sum + 124* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dV":
                        sum = sum + 125* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dW":
                        sum = sum + 126* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dX":
                        sum = sum + 127* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dY":
                        sum = sum + 128* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "dZ":
                        sum = sum + 129* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;


                    case "eA":
                        sum = sum + 130* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eB":
                        sum = sum + 131* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eC":
                        sum = sum + 132* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eD":
                        sum = sum + 133* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eE":
                        sum = sum + 134* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eF":
                        sum = sum + 135* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eG":
                        sum = sum + 136* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eH":
                        sum = sum + 137* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eI":
                        sum = sum + 138* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eJ":
                        sum = sum + 139* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eK":
                        sum = sum + 140* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eL":
                        sum = sum + 141* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eM":
                        sum = sum + 142* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eN":
                        sum = sum + 143* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eO":
                        sum = sum + 144* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eP":
                        sum = sum + 145* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eQ":
                        sum = sum + 146* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eR":
                        sum = sum + 147* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eS":
                        sum = sum + 148* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eT":
                        sum = sum + 149* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eU":
                        sum = sum + 150* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eV":
                        sum = sum + 151* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eW":
                        sum = sum + 152* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eX":
                        sum = sum + 153* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eY":
                        sum = sum + 154* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "eZ":
                        sum = sum + 155* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;


                    case "fA":
                        sum = sum + 156* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "fB":
                        sum = sum + 157* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "fC":
                        sum = sum + 158* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "fD":
                        sum = sum + 159* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "fE":
                        sum = sum + 160* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "fF":
                        sum = sum + 161* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "fG":
                        sum = sum + 162* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "fH":
                        sum = sum + 163* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "fI":
                        sum = sum + 164* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "fJ":
                        sum = sum + 165* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "fK":
                        sum = sum + 166* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    case "fL":
                        sum = sum + 167* (long)Math.Pow(168.0, (duranDigits.Length - 1 - i)); break;
                    default:
                        Console.WriteLine("Some mistake");break;
                
                }
            }
            Console.WriteLine(sum);
        }
    }

