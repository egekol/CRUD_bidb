using System;
using System.Collections.Generic;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirlerList = new List<string>();
            sehirlerList.Add("Bilecük");
            Console.WriteLine(sehirlerList[0]);
            Console.WriteLine(sehirlerList.Count);
            Console.WriteLine("Hello World!");

            MyList<string> sehirlerMyList = new MyList<string>();
            sehirlerMyList.Add("İstanbul");
            Console.WriteLine(sehirlerMyList.Count);
        }
    }

    class MyList<T>
    {
        T[] _array;

        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                _array[i] = tempArray[i];
            }

            _array[^1] = item;

        }

        public int Count
        {
            get { return _array.Length; }
        }
    }
}
