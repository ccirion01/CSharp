using System.Collections;

namespace IEnumerator_IEnumerable
{
    public class MyInfiniteEnumerable : IEnumerable<int>
    {
        private int[] _myData = new int[] {4, 5, 6};
        public IEnumerator<int> GetEnumerator()
        {
            return new MyInfiniteEnumerator(_myData);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyInfiniteEnumerator(_myData);
        }
    }

    public class MyInfiniteEnumerator : IEnumerator<int>
    {
        private int[] _data;
        private int _mIndex = -1;

        public MyInfiniteEnumerator(int[] data)
        {
            _data = data;
        }

        public int Current => _data[_mIndex];
        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            _mIndex++;
            return _mIndex < _data.Length;
        }

        public void Reset()
        {
            _mIndex = 0;
        }
    }
}
