namespace Generic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GenericList<T>
        where T : IComparable<T>
    {
        private T[] list;
        private int capacity;
        private int counter;

        public GenericList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new IndexOutOfRangeException();
            }

            this.capacity = capacity;
            this.list = new T[this.capacity];
        }

        public void AddElement(T element)
        {
            if (this.list.Length > this.capacity)
            {
                throw new IndexOutOfRangeException();
            }

            this.list[this.counter] = element;
            this.counter++;

            if (this.capacity - 1 < this.counter)
            {
                this.AutoGrow();
            }
        }

        public T this[int index]
        {
            get
            {
                if (index > this.list.Length - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.list[index];
            }

            set
            {
                if (index < 0 || index > this.list.Length - 1)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void RemovingElement(int index)
        {
            if (index > this.list.Length - 1 || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < this.list.Length - 2; i++)
            {
                this.list[i] = this.list[i + 1];
            }

            this.list[this.list.Length - 1] = default(T);
            this.counter--;
        }

        public void InsertElement(T element, int index)
        {
            if (this.capacity - 1 < this.counter)
            {
                this.AutoGrow();
            }

            if (index < 0 || index >= this.list.Length)
            {
                throw new IndexOutOfRangeException();
            }

            T[] copyee = new T[this.capacity];
            this.list.CopyTo(copyee, 0);

            for (int i = index + 1; i < this.list.Length; i++)
            {
                this.list[i] = copyee[i - 1];
            }

            this.list[index] = element;
            this.counter++;
        }

        public void AutoGrow()
        {
            T[] copy = new T[this.capacity];
            this.list.CopyTo(copy, 0);
            this.list = new T[this.capacity * 2];
            copy.CopyTo(this.list, 0);
            this.capacity = this.capacity * 2;
        }

        public void ClearList()
        {
            List<T> copy = new List<T>();
            copy.AddRange(this.list);
            copy.Clear();
            this.list = copy.ToArray();
        }

        public T MaxValue()
        {
            T[] copy = new T[this.capacity];
            this.list.CopyTo(copy, 0);
            Array.Sort(copy);
            return copy[copy.Length - 1];
        }

        public T MinValue()
        {
            T min = this.list[0];
            foreach (var elements in this.list)
            {
                if (min.CompareTo(elements) > 0)
                {
                    min = elements;
                }
            }

            return min;
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            for (int i = 0; i < this.counter; i++)
            {
                st.AppendFormat("[{0}] = {1}", i, this.list[i].ToString());
                st.AppendLine();
            }

            return st.ToString();
        }
    }
}