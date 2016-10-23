using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class GenericListEnumerator<X> : IEnumerator<X>
    {
        private GenericList<X> _list;
        private int _position;

        public X Current
        {
            get
            {
                try
                {
                    return _list.GetElement(_position);
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public GenericListEnumerator(GenericList<X> list) 
        {
            _position = -1;
            _list = list;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < _list.Count);
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
