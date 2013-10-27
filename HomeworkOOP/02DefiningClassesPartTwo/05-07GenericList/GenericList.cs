//5. Write a generic class GenericList<T> that keeps a list of elements of some 
//parametric type T. Keep the elements of the list in an array with
//fixed capacity which is given as parameter in the class 
//constructor. Implement methods for adding element, accessing 
//element by index, removing element by index, inserting element 
//at given position, clearing the list, finding element by its 
//value and ToString(). Check all input parameters to avoid 
//accessing elements at invalid positions.

//6. Implement auto-grow functionality: when the internal array is full, create a 
//new array of double size and move all elements to it.
     

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_07GenericList
{
    public class GenericList<T>
    {
        // Private Constants
        private const int defaulCapacity = 1;

        private T[] arrayOfElements;
        private int count;

        public GenericList(int capacity)
        {
            arrayOfElements = new T[capacity];
        }

        public GenericList()
            : this(defaulCapacity)
        {
        }

        public int Count
        {
            get { return this.count; }
        }       

        public int IndexOf(T element)
        {
            for (int i = 0; i < arrayOfElements.Length; i++)
            {
                if (element.Equals(arrayOfElements[i]))
                {
                    return i;
                }
            }
            
            return -1;
        }

        public void Clear()
        {
            arrayOfElements = new T[arrayOfElements.Length];
            count = 0;
        }

        public void AddElementAtIndex(int index, T element)
        {
            try
            {
                if (count + 1 >= arrayOfElements.Length)
                {
                    arrayOfElements = (T[])ExtendArray();
                }

                count++;
                T[] newArray = new T[count];
                for (int i = 0; i < count ; i++)
                {
                    if (i < index)
                    {
                        newArray[i] = arrayOfElements[i];
                    }
                    else if (i==index)
                    {
                        newArray[i] = element;
                    }
                    else if (i > index)
                    {
                        newArray[i] = arrayOfElements[i - 1];
                    }
                }

                arrayOfElements = (T[])newArray.Clone();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Index was outside the boundaries of the array!.This command will not be fullfiled");
            }
        }

        public void RemoveElementAtIndex(int index)
        {
            try
            {
                T[] newArray = new T[count - 1];

                for (int i = 0; i < count - 1; i++)
                {
                    if (i < index)
                    {
                        newArray[i] = arrayOfElements[i];
                    }
                    else if (i > index)
                    {
                        newArray[i] = arrayOfElements[i + 1];
                    }
                }

                count--;
                arrayOfElements = (T[])newArray.Clone();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Index was outside the boundaries of the array!.This command will not be fullfiled");
            }
        }

        public void Add(T element)
        {
            if (count + 1 >= arrayOfElements.Length)
            {
                arrayOfElements = (T[])ExtendArray();
            }
            this.arrayOfElements[count] = element;
            count++;
        }

        private T[] ExtendArray()
        {
            T[] extendArray = new T[arrayOfElements.Length * 2];
            int possition = 0;
            foreach (var element in arrayOfElements)
            {
                extendArray[possition] = element;
                possition++;
            }
            return extendArray;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(arrayOfElements[i] + "   ");
            }
            return result.ToString();
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = arrayOfElements[index];
                return result;
            }
        }

        //7.Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  
        //GenericList<T>. You may need to add a generic constraints for the type T.

        public T Min<T>() where T : IComparable<T>, IComparable
        {
            dynamic min = arrayOfElements.Min();
            return min;
        }

        public T Max<T>() where T : IComparable<T>, IComparable
        {
            dynamic max = arrayOfElements.Max();
            return max;
        }
    }
}