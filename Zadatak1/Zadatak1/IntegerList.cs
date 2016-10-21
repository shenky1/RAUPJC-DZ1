using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class IntegerList : IIntegerList
    {

        private int[] _internalStorage;
        private int _count;
        private int _capacity;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public IntegerList()
        {
            _internalStorage = new int[4];
            _capacity = 4;
            _count = 0;
        }

        public IntegerList(int initialSize)
        {
            if(initialSize < 1)
            {
                throw new ArgumentException("Size of array must be greater than one!");
            }

            _capacity = initialSize;
            _internalStorage = new int[initialSize];
            _count = 0;
        }

        public void Add(int item)
        {
            if (Count == _capacity )
            {
                Reallocating();
            }
            _internalStorage[_count] = item;
            _count++;
        }

        private void Reallocating()
        {
            _capacity = 2 * _capacity;
            int[] doubledArray = new int[_capacity];
            for (int i = 0; i < _count; i++)
            {
                doubledArray[i] = _internalStorage[i];
            }
            _internalStorage = doubledArray;
        }

        public void Clear()
        {
            for (int i = Count - 1; i <= 0; i--)
            {
                _internalStorage[i] = 0;
            }

            _count = 0;
        }

        public bool Contains(int item)
        {
           if(this.IndexOf(item) != -1)
            {
                return true;
            }
            return false;
        }

        public int GetElement(int index)
        {
            if (index < 0 || index > _count - 1)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Index is wrong!");
            }
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_internalStorage[i] == item)
                    return i;
            }

            return -1;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index > _count - 1)
            {
                return false;
            }

            for (int i = index; i <= _count - 2; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }

            _internalStorage[_count - 1] = 0;
            _count--;
            return true;
        }

         public bool Remove(int item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_internalStorage[i] == item)
                    return this.RemoveAt(i);
            }

            return false;
        }
    }
}
