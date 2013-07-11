using System;
using System.Collections;
using System.Collections.Generic;

namespace BitArray
{
    /// <summary>
    /// Holds 64 bit values inside an ulong value. Implements IEnumerable.
    /// </summary>
    public class BitArray64 : IEnumerable<int>
    { /*5. Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.*/
        
        #region Private Fields

        /// <summary>
        /// Number used to store data.
        /// </summary>
        private ulong number;

        #endregion
        
        #region Constructor
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BitArray64"/> class. Holds 64 bit values inside
        /// </summary>
        /// <param name="number">Default parameter number = 0</param>
        public BitArray64(ulong number = 0)
        {
            this.Number = number;
        }
        
        #endregion
        
        #region Public Properties
        
        /// <summary>
        /// Gets Number.
        /// </summary>
        public ulong Number
        {
            get 
            {
                return this.number;
            }
            
            private set
            {
                this.number = value;
            }
        }

        #endregion
        
        #region Indexer
        
        /// <summary>
        /// BitArray64 indexer
        /// </summary>
        /// <param name="index">Range [0,63]</param>
        /// <returns>Zero or One</returns>
        public int this [int index]
        { 
            get 
            {
                ulong mask = (ulong)1 << index;
                return (this.Number & mask) != 0 ? 1 : 0;
            }
            
            set
            {
                if (index > 63 || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else if (value == 1)
                {
                    ulong mask = (ulong)1 << index;
                    this.Number |= mask;
                }
                else if (value == 0)
                {
                    ulong mask = (ulong)1 << index;
                    this.Number &= ~mask;
                }
            }
        }
        
        #endregion
        
        #region Overrided Methods
        
        /// <summary>
        /// Checks if objects contains identical data.
        /// </summary>
        /// <param name="first">First BitArray.</param>
        /// <param name="second">Second BitArray.</param>
        /// <returns>True or false.</returns>
        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        /// <summary>
        /// Checks if objects contains different data.
        /// </summary>
        /// <param name="first">First BitArray.</param>
        /// <param name="second">Second BitArray.</param>
        /// <returns>True or false.</returns>
        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }
        
        /// <summary>
        /// Checks if objects contain same data.
        /// </summary>
        /// <param name="obj">BitArray64 expected</param>
        /// <returns>Equal or not</returns>
        public override bool Equals(object obj)
        {
            BitArray64 num = obj as BitArray64;
            if (num == null)
            {
                return false;
            }
            
            if (this.Number != num.Number)
            {
                return false;
            }
        
            return true;
        }
        
        /// <summary>
        /// Calculates object hash code.
        /// </summary>
        /// <returns>Calculated Hash.</returns>
        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }
        
        /// <summary>
        /// Beautify Printing in human readable format.
        /// </summary>
        /// <returns>Beautified number.</returns>
        public override string ToString()
        {
            return Convert.ToString((long)this.Number, 2).PadLeft(64, '0');
        }
        
        #endregion
        
        #region Methods
        
        /// <summary>
        /// Walk through bits and get IEnumerator.
        /// </summary>
        /// <returns>Current</returns>
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this[i];
            }
        }
        
        /// <summary>
        /// Non Generic version. Walk through bits.
        /// </summary>
        /// <returns>IEnumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<int>).GetEnumerator();
        }

        #endregion
    }
}