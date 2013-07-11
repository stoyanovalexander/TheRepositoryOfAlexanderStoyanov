using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListMethods
{
    public class GenericListClass<T>
        where T : IComparable
    {
        //Fields
        private T[] elements;
        private int count = 0;
        private int capacity;

        //Constructors
        public GenericListClass(int someCapacity)
        {
            this.capacity = someCapacity;
            elements = new T[someCapacity];
        }

        //Properties
        public int Count
        {
            get
            {
                return this.count;
            }
        }
        public int Capacity
        {
            get { return this.capacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The capacity must be positive number!");
                }
                this.capacity = value;
            }
        }

        //Methods
        public T[] Add(T element)
        {
            if (count >= elements.Length)
            {
                AutoGrow();
            }
            else
            {
                this.elements[count] = element;
                count++;
            }
            return elements;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        public T[] RemoveAtIndex(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("The index must be a positive number!");
            }
            if (index <= count)
            {
                for (int i = index; i < count; i++)
                {
                    elements[i] = elements[i + 1];
                }
                count--;
            }
            else
            {
                throw new ArgumentException("This position is still empty!");
            }
            return elements;
        }

        public T[] Clear()
        {
            elements = new T[elements.Length];
            count = 0;
            return elements;
        }

        public T[] InsertAtPosition(int index, T element)
        {
            if ((index < 0) || (index >= elements.Length))
            {
                throw new IndexOutOfRangeException("No such index exists in the array");
            }
            if (count >= elements.Length)
            {
                AutoGrow();
            }
            if ((index >= 0) && (index <= count))
            {
                for (int i = count; i >= index + 1; i--)
                {
                    elements[i] = elements[i - 1];
                }
                elements[index] = element;
                count++;
            }
            return elements;
        }

        public int FindByValue(T element)
        {
            return Array.IndexOf(elements, element);
        }

        public override string ToString()
        {
            string theString = null;
            for (int i = 0; i <= count; i++)
            {
                theString = theString + "element[" + i + "]=" + elements[i];
                if (i < count - 1)
                {
                    theString += " ,  ";
                }
            }
            return theString;
        }
        private void AutoGrow()
        {
            T[] tempArray = new T[elements.Length * 2];
            Array.Copy(elements, 0, tempArray, 0, elements.Length);
            elements = tempArray;
            Capacity *= 2; ;
        }

        public T Max()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Sequence is Empty!");
            }

            if (this.count == 1)
            {
                return this.elements[0];
            }

            if (this.elements[0] is IComparable<T>)
            {
                T max = this.elements[0];

                for (int i = 1; i < this.count; i++)
                {
                    if ((max as IComparable<T>).CompareTo(this.elements[i]) < 0)
                    {
                        max = this.elements[i];
                    }
                }

                return max;
            }
            else
            {
                throw new ArgumentException("At least one object must implement IComparable.");
            }
        }

        public T Min()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements.");
            }

            if (this.count == 1)
            {
                return this.elements[0];
            }

            if (this.elements[0] is IComparable<T>)
            {
                T min = this.elements[0];

                for (int i = 1; i < this.count; i++)
                {
                    if ((min as IComparable<T>).CompareTo(this.elements[i]) > 0)
                    {
                        min = this.elements[i];
                    }
                }

                return min;
            }
            else
            {
                throw new ArgumentException("At least one object must implement IComparable.");
            }
        }
    }
}
