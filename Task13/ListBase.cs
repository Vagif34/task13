namespace Task13
{
    internal class ListBase
    {
        public bool Exist(T item)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (object.Equals(_arr[i], item))
                {
                    return true;
                }
                return false;
            }
        }
    }
}