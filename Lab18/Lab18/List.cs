using System;
using System.Collections.Generic;

namespace Lab18
{
    public class List
    {
        private int _count = 0;
        private readonly string[] _array;
        private Object p;


        public List(int maxLength)
        {
            _array = new string[maxLength];
        }

        public int Count()
        {
            return _count;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public void Reverse()
        {
            Array.Reverse(_array);
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }
        }

        public bool IsFull()
        {
            return _count == _array.Length;
        }

        public bool Insert(string value)
        {
            if (IsFull())
            {
                return false;
            }

            _array[_count] = value;
            _count++;
            return true;
        }

        public bool RemoveAt(int index)
        {
            for (int i = index; i < _count; i++)
            {
                _array[i] = _array[i + 1];
            }

            _count--;

            if (index > _count)
            {
                return false;
            }
            return true;

            




        }

      

        public bool InsertAt(int index, Object o)
        {
            for (int i = index; i < _count; i++)
            {
                _array[i] = _array[i + 1];


            }
            if (index > _count)
            {
                return false;
            }
            else
            {
                _array[_count] = (string)o;
                _count++;
                return true;
            }

        }

        public void Print()
        {
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}