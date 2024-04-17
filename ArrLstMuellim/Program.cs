using System.Collections.Generic;

namespace ArrLstMuellim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntArrayList list = new IntArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(44);
            list.Add(42);
            list.Add(44);
            list.Add(42);
            list.GetElements();
        }
        class IntArrayList
        {
            int[] _arr;
            public int Capastiy { get; set; } = 5;
            public int Count { get; set; } = 0;
            public IntArrayList() {
                _arr = new int[Capastiy];
            }
            public IntArrayList(int capastiy) {
                Capastiy = capastiy;
                _arr = new int[Capastiy];
            }
            public void Add(int value)
            {
                if(_arr.Length == Count)
                {
                    Array.Resize(ref _arr,Count+Capastiy);
                }
                _arr[Count] = value;
                Count++;
            }
            public void GetElements()
            {
                for (int i = 0; i < _arr.Length; i++)
                {
                    Console.WriteLine(_arr[i]);
                }
            }
        }
    }
}
