using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class GenericList <X> : IGenericList <X>
    {

        private X[] _internalStorage;
        private int _count;
        private int _capacity;

        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public GenericList()
        {
            _internalStorage = new X[4];
            _capacity = 4;
            _count = 0;
        }

        public GenericList(int initialSize)
        {
            if(initialSize < 1)
            {
                throw new ArgumentException("Size of array must be greater than one!");
            }

            _capacity = initialSize;
            _internalStorage = new X[initialSize];
            _count = 0;
        }

        public void Add(X item)
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
            X[] doubledArray = new X[_capacity];
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
                _internalStorage[i] = default(X);
            }

            _count = 0;
        }

        public bool Contains(X item)
        {
           if(this.IndexOf(item) != -1)
            {
                return true;
            }
            return false;
        }

        public X GetElement(int index)
        {
            if (index < 0 || index > _count - 1)
            {
                throw new IndexOutOfRangeException("Index is wrong!");
            }
            return _internalStorage[index];

        }

        public int IndexOf(X item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_internalStorage[i].Equals(item))
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

            _internalStorage[_count - 1] = default(X);
            _count--;
            return true;
        }

         public bool Remove(X item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_internalStorage[i].Equals(item))
                    return this.RemoveAt(i);
            }

            return false;
        }
    }
}
