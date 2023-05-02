using labor11;
using System.Net.Http.Headers;

namespace labor11
{
    public  class MyTriple<T,U,F>:MyPair<T,U>
    {
        private F Value3;
        public MyTriple(T value, U value2, F value3):base(value,value2)
        {
            Value3 = value3;
        }
        public object this[int index]
        {
            get
            {
                if(index == 0 || index == 1)
                {
                    return base[index];
                }
                else if(index == 2)
                {
                    return Value3;
                }
                else { throw new IndexOutOfRangeException(); }
            }
            set
            {
                if (index == 0 || index == 1)
                {
                    base[index] = value;
                }
                else if(index ==2) { Value3 = (F)value; }
                else {  throw new IndexOutOfRangeException(); }
            }
        }
    }
}
