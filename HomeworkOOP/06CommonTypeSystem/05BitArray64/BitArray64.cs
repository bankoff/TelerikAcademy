//5. Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> 
//   and Equals(…), GetHashCode(), [], == and !=.

using System;
using System.Collections.Generic;
using System.Collections;

class BitArray64 : IEnumerable<int>
{
    private ulong number;

    public ulong Number
    {
        get { return number; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid input!!!");
            }
            else
            {
                number = value;
            }
        }
    }

    //constructor
    public BitArray64(ulong number = 0)
    {
        this.Number = number;
    }

    //ienumerable interface
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public IEnumerator<int> GetEnumerator()
    {
        int[] bits = this.ConvertToBits();

        for (int i = 0; i < bits.Length; i++)
        {
            yield return bits[i];
        }
    }

    //property to return array of all bits
    public int[] Bits
    {
        get { return this.ConvertToBits(); }
    }

    //method for converting
    private int[] ConvertToBits()
    {
        ulong value = this.Number;

        int[] bits = new int[64];
        int counter = 63;

        while (value != 0)
        {
            bits[counter] = (int)(value % 2);
            value /= 2;
            counter--;
        }

        while (counter >= 0)
        {
            bits[counter] = 0;
            counter--;
        }

        return bits;
    }

    //equals
    public bool Equals(BitArray64 value)
    {
        if (ReferenceEquals(null, value))
        {
            return false;
        }
        if (ReferenceEquals(this, value))
        {
            return true;
        }
        return this.Number == value.Number;
    }

    public override bool Equals(object obj)
    {
        BitArray64 temp = obj as BitArray64;
        if (temp == null)
            return false;
        return this.Equals(temp);
    }

    //hash code
    public override int GetHashCode()
    {
        return this.Number.GetHashCode() ^ this.Bits.GetHashCode();
    }

    //indexator
    private bool IndexChecker(int index)
    {
        if (index < 0 || index > 63)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //index to check the bit at position
    public int this[int index]
    {
        get
        {
            if (IndexChecker(index))
            {
                throw new System.IndexOutOfRangeException();
            }

            int[] bits = this.ConvertToBits();
            return bits[index];
        }
    }

    //== operator
    public static bool operator ==(BitArray64 first, BitArray64 second)
    {
        return BitArray64.Equals(first, second);
    }

    //!= operator
    public static bool operator !=(BitArray64 first, BitArray64 second)
    {
        return !BitArray64.Equals(first, second);
    }
}