using System.Data;

namespace Person1
{
    class Agecomparer : IComparer<Person>
    {
        public int Compare(Person? person1,Person? person2)
        {
            if (person1 == null || person2 == null)
            {
                throw new ArgumentException("Параментр некоректный!");
            }
            return person1.Name.Length - person2.Name.Length;
        }
    }
    class PlintusComparer : IComparer<Person>
    {
        public int Compare(Person? person1,Person? person2)
        {
            if (person1 == null || person2 == null)
            {
                throw new ArgumentException("Параментр некоректный!");
            }
            return (int)person1.S-(int)person2.S;
        }
    }
    class Person: IComparable<Person>
    {
        public Person() { }

        public Person(string surname, string name, DateTime birth, char s)
        {
            Surname = surname;
            Name = name;
            Birth = birth;
            S = s;
        }
        public Person(Person a)
        {
            Surname = a.Surname;
            Name = a.Name;
            Birth = a.Birth;
            S = a.S;
        }
        public char S
        {
            get { return _s; }
            set
            {
                if (_s == 'M' || _s == 'm' | _s == 'F' | _s == 'f' | _s == 'м' | _s == 'ж' | _s == 'М' | _s == 'Ж')
                    _s = value;
            }
        }
        public void Output()
        {
            Console.WriteLine(Surname + " " + Name + " " + fullage() + " " + S);
        }
        public void Input()
        {
            Console.WriteLine("Введите фамилию: ");
            Surname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите имя: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите дату рождения: ");
            Birth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите пол: ");
            _s = Convert.ToChar(Console.ReadLine());
        }
        public int fullage()
        {
            DateTime b = DateTime.Now;
            return Convert.ToInt32(b.Subtract(Birth).TotalDays / 365);
        }
        
        public int CompareTo(Person? person)
        {
            if (person == null) throw new Exception("Некорретное значение аргумента!");
            return Name.CompareTo(person.Name);
        } 
        static public Person Push1(Person[] a)
        {
            Person max = a[0];
            for(int i = 0; i < a.Length; i++)
            {
                if (max.CompareTo(a[i]) < 0)
                {
                    max = a[i];
                }
            }
            return max;
        }


        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        private char _s;
    }
}
