using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _5.BitArray64
{
    public class BitArray64 : IEnumerable<int>
    {
        private int[] bitArray = new int[64];
        private ulong number;

        public BitArray64(ulong number)
        {
            this.number = number;
            // fills array with bits of the number
            for (int i = 0; i < 64; i++)
            {
                bitArray[i] = (int)(number % 2);
                number /= 2;
            }
        }

        // PROPERTIES -------------------------------------------------------------------
        public ulong Number
        {
            get { return this.number; }
        }

        // METHODS ---------------------------------------------------------------------
        // implement foreach
        IEnumerator IEnumerable.GetEnumerator()
        {
            // Call the generic version of the method
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this.bitArray[i];
            }
        }

        public override bool Equals(object obj)
        {
            BitArray64 bitArray = obj as BitArray64;

            if ((object)bitArray == null)
            {
                return false;
            }

            if (Object.Equals(this.number, bitArray.number))
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(BitArray64 firstNumber,
                                  BitArray64 secondNumber)
        {
            return BitArray64.Equals(firstNumber, secondNumber);
        }

        public static bool operator !=(BitArray64 firstNumber,
                           BitArray64 secondNumber)
        {
            return !(BitArray64.Equals(firstNumber, secondNumber));
        }

        public int this[int key]
        {
            get { return this.bitArray[key]; }
            set
            {
                if (value == 1 || value == 0)
                {
                    this.bitArray[key] = value;
                    ChangeNumber();
                }
                else
                {
                    throw new ArgumentException("You can insert only bits 0 and 1.");
                }
            }
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode() ^ this.bitArray.GetHashCode();
        }

        // this method change number after we change somewhere some bit
        private void ChangeNumber()
        {
            this.number = 0;
            // calculate new number
            for (int i = 0; i < 64; i++)
            {
                this.number += (ulong)(this.bitArray[i] << i); // with this shift I make pow
            }
        }
    }
}
