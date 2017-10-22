using System;
using System.Linq;

namespace Task1
{
     public class IntegerList : IIntegerList
     {
         private int[] _internalStorage;
         private int _size = 0;
         private int _internalStorageSize;
         public int Count {
             get { return _size; }
         }

        public IntegerList()
        {
            _internalStorageSize = 4;
            _internalStorage = new int[_internalStorageSize];
         }

         public IntegerList(int initialSize)
         {
             if (initialSize < 0)
             {
                throw new Exception("Array length cannot be negative!");
             }
             else
             {
                 _internalStorage = new int[initialSize];
                 _internalStorageSize = initialSize;
             }
         }

        public void Add(int item)
        {
            if (_size == _internalStorage.Length)
            {
                _internalStorageSize = _internalStorage.Length * 2;
                int[] temp = new int[_internalStorageSize];
                for (int i = 0; i < _size; i++)
                {
                    temp[i] = _internalStorage[i];
                }
                _internalStorage = new int[_internalStorageSize];
                for (int i = 0; i < _size; i++)
                {
                    _internalStorage[i] = temp[i];
                }
            }

            _internalStorage[_size] = item;
            _size++;
        }

        public bool Remove(int item)
        {
            if (!_internalStorage.Contains(item))
            {
                return false;
            }

            for (int i = 0; i < _size; i++)
            {
                if (_internalStorage[i] == item)
                {
                    RemoveAt(i);
                    break;
                }
            }
            return true;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index > _size - 1)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < _size - 1; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }

            _size--;
            return true;
        }

        public int GetElement(int index)
        {
            if (index < 0 || index > _size - 1)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return _internalStorage[index];
            }
        }

        public int IndexOf(int item)
        {
            if (Contains(item))
            {
                for (int i = 0; i < _size; i++)
                {
                    if (_internalStorage[i] == item)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public void Clear()
        {
            _internalStorage = new int[_internalStorageSize];
            _size = 0;
        }

        public bool Contains(int item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
