using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Exist(1);
            list.Clear();
        }

        
    }

    class List<T>where T:new()
    {
         
        T[] _arr;
        public int Count { get => _arr.Length; }
        public  List()
        {
            _arr = new T[0];
            T a = new T();
        }
        public T this[int index]
        {
            get
            {
                if (index < _arr.Length)
                {
                    return _arr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index < _arr.Length)
                {
                    _arr[index] = value;
                }
                throw new IndexOutOfRangeException();
            }
        }
        public bool Exist(T item)
        {
            for (int i = 0; i <_arr.Length; i++)
            {
                if (object.Equals( _arr[i],item))
                {
                    return true;
                }
                return false;
            }
        }
        public void Clear()
        {
            _arr = new T[0];
        }
        public void Remove()
        {
            for (int  i =IndexOf(item); i<_arr.Length-1; i++)
            {
             
            }
        }
        public void Reverse()
        {

        }

    }

}
