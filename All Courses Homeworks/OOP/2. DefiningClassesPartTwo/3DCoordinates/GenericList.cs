namespace Coordinates
{
    using System;

    public class GenericList<T> where T : IConvertible, IComparable
    {
        private T[] arr;
        private int capacity;
        private int currentPos = 0;

        public GenericList(int capacity)
        {
            this.capacity = capacity;
            this.arr = new T[this.capacity];
        }

        public T this[int index]
        {
            get
            {
                return this.arr[index];
            }
        }

        public void Add(T item)
        {
            if (currentPos >= this.capacity)
            {
                this.capacity = capacity * 2;
                T[] temp = new T[capacity];
                Array.Copy(arr, temp, arr.Length);
                this.arr = new T[capacity];
                Array.Copy(temp, arr, temp.Length);
                temp = null;
            }
            arr[currentPos] = item;
            currentPos++;
        }

        public void Remove(int index)
        {
            if (index >= this.capacity)
            {
                throw new ArgumentOutOfRangeException("Index was out of range");
            }

            GenericList<T> list = this;
            list.capacity = list.capacity - 1;

            if (index < this.capacity)
            {
                Array.Copy(this.arr, index + 1, this.arr, index, this.capacity - index);
            }

            this.arr[this.capacity] = default(T);
        }

        public void Insert(T item, int position)
        {
            if (position >= this.capacity)
            {
                throw new ArgumentOutOfRangeException("Index was out of range");
            }
            GenericList<T> list = this;

            if (position < this.capacity)
            {
                Array.Copy(this.arr, position, this.arr, position + 1, this.capacity - position);
                this.arr[position] = item;
            }

            this.arr[this.capacity] = default(T);
        }

        public void Clear()
        {
            this.arr = new T[capacity];
        }

        public void Contains(T value)
        {
            bool contains = false;
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (arr[i].Equals(value))
                {
                    Console.WriteLine("Element {0} is at index [{1}]", value, i);
                    contains = true;
                }
            }
            if (contains == false)
            {
                Console.WriteLine("In this collection doesn't contain element [{0}]", value);
            }

        }

        public string ToString(int index)
        {
            if (index >= this.capacity)
            {
                throw new ArgumentOutOfRangeException("Index was out of range");
            }
            return arr[index].ToString();
        }

        public void Min()
        {
            int indexer = 1;
            T minElement = (T)GetTMaxValue();
            // T currentElement ;
            for (int i = 0; i < this.arr.Length - 1; i++)
            {
                T currentElement = arr[i];

                if (currentElement.CompareTo(arr[indexer]) < 0)
                {
                    if (currentElement.CompareTo(minElement) < 0)
                    {
                        if (currentElement.CompareTo(default(T)) != 0)
                        {
                            minElement = currentElement;
                        }
                    }
                }

                indexer++;
            }
            Console.WriteLine("Min Element is : {0}", minElement);
        }

        public void Max()
        {
            int indexer = 1;
            T maxElement = (T)GetMinValue();
            // T currentElement ;
            for (int i = 0; i < this.arr.Length - 1; i++)
            {
                T currentElement = arr[i];

                if (currentElement.CompareTo(arr[indexer]) > 0)
                {
                    if (currentElement.CompareTo(maxElement) > 0)
                    {
                        if (currentElement.CompareTo(default(T)) != 0)
                        {
                            maxElement = currentElement;
                        }
                    }
                }

                indexer++;
            }
            Console.WriteLine("Min Element is : {0}", maxElement);
        }

        private object GetTMaxValue()
        {
            TypeCode typeCode = Type.GetTypeCode(typeof(T));
            object maxValue = null;
            switch (typeCode)
            {
                case TypeCode.Byte:
                    maxValue = byte.MaxValue;
                    break;
                case TypeCode.Char:
                    maxValue = char.MaxValue;
                    break;
                case TypeCode.DateTime:
                    maxValue = DateTime.MaxValue;
                    break;
                case TypeCode.Decimal:
                    maxValue = decimal.MaxValue;
                    break;
                case TypeCode.Double:
                    maxValue = decimal.MaxValue;
                    break;
                case TypeCode.Int16:
                    maxValue = short.MaxValue;
                    break;
                case TypeCode.Int32:
                    maxValue = int.MaxValue;
                    break;
                case TypeCode.Int64:
                    maxValue = long.MaxValue;
                    break;
                case TypeCode.SByte:
                    maxValue = sbyte.MaxValue;
                    break;
                case TypeCode.Single:
                    maxValue = float.MaxValue;
                    break;
                case TypeCode.UInt16:
                    maxValue = ushort.MaxValue;
                    break;
                case TypeCode.UInt32:
                    maxValue = uint.MaxValue;
                    break;
                case TypeCode.UInt64:
                    maxValue = ulong.MaxValue;
                    break;
                default:
                    maxValue = default(T);//set default value
                    break;
            }

            return maxValue;
        }

        private object GetMinValue()
        {
            TypeCode typeCode = Type.GetTypeCode(typeof(T));
            object minValue = null;
            switch (typeCode)
            {
                case TypeCode.Byte:
                    minValue = byte.MinValue;
                    break;
                case TypeCode.Char:
                    minValue = char.MinValue;
                    break;
                case TypeCode.DateTime:
                    minValue = DateTime.MinValue;
                    break;
                case TypeCode.Decimal:
                    minValue = decimal.MinValue;
                    break;
                case TypeCode.Double:
                    minValue = decimal.MinValue;
                    break;
                case TypeCode.Int16:
                    minValue = short.MinValue;
                    break;
                case TypeCode.Int32:
                    minValue = int.MinValue;
                    break;
                case TypeCode.Int64:
                    minValue = long.MinValue;
                    break;
                case TypeCode.SByte:
                    minValue = sbyte.MinValue;
                    break;
                case TypeCode.Single:
                    minValue = float.MinValue;
                    break;
                case TypeCode.UInt16:
                    minValue = ushort.MinValue;
                    break;
                case TypeCode.UInt32:
                    minValue = uint.MinValue;
                    break;
                case TypeCode.UInt64:
                    minValue = ulong.MinValue;
                    break;
                default:
                    minValue = default(T);//set default value
                    break;
            }

            return minValue;
        }
    }
}