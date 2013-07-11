using System;
using System.Text;

namespace People
{
    /// <summary>
    /// Stores Person data.
    /// </summary>
    public class Person
    { /* 4. Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
        * Override ToString() to display the information of a person and if age is not specified – to say so. 
        * Write a program to test this functionality.*/
        
        #region Private Fields
        
        /// <summary>
        /// Person Name.
        /// </summary>
        private string name;

        /// <summary>
        /// Person Age.
        /// </summary>
        private uint? age;

        #endregion
        
        #region Constructors
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class.
        /// </summary>
        /// <param name="name">Person Name.</param>
        public Person(string name) : this(name, null)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class.
        /// </summary>
        /// <param name="name">Person Name.</param>
        /// <param name="age">Person Age</param>
        public Person(string name, uint? age)
        {
            this.Name = name;
            this.Age = age;
        }
        
        #endregion
        
        #region Public Properties
        
        /// <summary>
        /// Gets or sets Person name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }

                this.name = value;
            }
        }
        
        /// <summary>
        /// Gets or sets Person age. Can be null.
        /// </summary>
        public uint? Age
        {
            get
            {
                return this.age;
            }
            
            set
            {
                if (value < 1 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("Age must be in range [1,120]");
                }

                this.age = value;
            }
        }
        
        #endregion
        
        #region Methods
        
        /// <summary>
        /// Print Person data. If Age is null - say so.
        /// </summary>
        /// <returns>Human readable person Data.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Name: {0} ; ", this.Name);
            if (this.Age != null)
            {
                result.AppendFormat("Age: {0} ; ", this.Age);
            }
            else
            {
                result.AppendLine("Age: Not Specified!");
            }
        
            return result.ToString();
        }

        #endregion  
    }
}