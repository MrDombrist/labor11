using System.Runtime.CompilerServices;

namespace labor11
{
    public class MyPair<T,U>
    {
        private T Value;
        private U Value2;
        public MyPair(T value, U value2)
        {
            Value = value;
            Value2 = value2;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return Value;
                }
                else if (index == 1)
                {
                    return Value2;
                }
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if(index == 0)
                {
                    Value = (T)value;
                }
                else if(index == 1)
                {
                    Value2 = (U)value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
