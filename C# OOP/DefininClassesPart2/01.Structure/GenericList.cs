namespace _01.Structure
{
    using System;
    using System.Text;

    class GenericList<T> where T : IComparable
    {
        private const int DefaultCapacity = 16;

        private T[] elements;
        private int index;

        public GenericList()
        {
            this.Capacity = DefaultCapacity;
            this.elements = new T[Capacity];
            this.index = 0;
        }

        public GenericList(int capacity)
            : this()
        {
            this.Capacity = capacity;
        }

        public int Capacity { get; private set; }

        public int Count
        {
            get
            {
                return this.elements.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }
            set
            {
                this.elements[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this.index == this.Capacity)
            {
                var newList = new T[this.Capacity * 2];
                for (int i = 0; i < this.index; i++)
                {
                    newList[i] = this.elements[i];
                }
                this.elements = newList;
            }
            this.elements[this.index] = element;
            this.index++;
        }

        public void RemoveAt(int index)
        {

            if (index < 0 || index > this.index)
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }
            var newList = new T[this.Capacity];
            int newListIndex = 0;
            for (int i = 0; i < index; i++)
            {
                newList[newListIndex] = this.elements[i];
                newListIndex++;
            }
            for (int i = index + 1; i < this.Count; i++)
            {
                newList[newListIndex] = this.elements[i];
                newListIndex++;
            }
            this.elements = newList;
        }

        public void InsertAt(int index, T item)
        {
            if (index < 0 || index > this.index)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (this.index == this.Capacity)
            {
                var doubleList = new T[this.Capacity * 2];
                this.elements = doubleList;
            }
            var newList = new T[this.Capacity];
            int newListIndex = 0;
            for (int i = 0; i < index; i++)
            {
                newList[newListIndex] = this.elements[i];
                newListIndex++;
            }
            newList[newListIndex] = item;
            newListIndex++;
            for (int i = index; i < this.index; i++)
            {
                newList[newListIndex] = this.elements[i];
                newListIndex++;
            }
            this.elements = newList;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < this.index; i++)
            {
                if (item.Equals(this.elements[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < this.index; i++)
            {
                text.Append(this.elements[i].ToString());
                text.Append(",");
            }
            return text.ToString();
        }

        //Problem 7
        public T Min()
        {
            T min = this.elements[0];
            for (int i = 1; i < this.index; i++)
            {
                if (min.CompareTo(this.elements[i])>0)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }

        //Problem 7
        public T Max()
        {
            T max = this.elements[0];
            for (int i = 1; i < this.index; i++)
            {
                if (max.CompareTo(this.elements[i]) < 0)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }

    }
}
