namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable
    {
        private List<ulong> list = new List<ulong>();

        public void Add(ulong number)
        {
            list.Add(number);
        }

        public ulong this[int i]
        {
            get { return this.list[i]; }
            set
            {
                if (value > (ulong)this.list.Count || value < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                this.list[i] = value;
            }
        }

        public static bool operator ==(BitArray64 firstArr, BitArray64 secondArr)
        {
            return firstArr.Equals(secondArr);
        }

        public static bool operator !=(BitArray64 firstArr, BitArray64 secondArr)
        {
            return !firstArr.Equals(secondArr);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        public override bool Equals(object obj)
        {
            BitArray64 arr = obj as BitArray64;
            if (arr is null)
            {
                return false;
            }

            if (this.list.Count != arr.list.Count)
            {
                return false;
            }

            for (int i = 0; i < arr.list.Count; i++)
            {
                if (this.list[i] != arr[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {


            return this.list.GetHashCode();
        }
    }
}