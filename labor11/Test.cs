
using labor11;
using Person1;
using System;
using System.Security.Cryptography.X509Certificates;

class Demo
{
    static void Main(string[] args)
    {
        //Random Random = new Random();          //1(a)
        //Console.WriteLine("Сколько человек вы хотите ввести? ");
        //int n = Convert.ToInt32(Console.ReadLine());    //Person
        //Person[] a = new Person[n];
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = new Person();
        //    a[i].Input();
        //}



        //foreach (Person p in a)
        //{
        //    p.Output();
        //}
        //Console.WriteLine("Каких ребят вы хотите поменять местами? ");
        //int x = Convert.ToInt32(Console.ReadLine());
        //int y = Convert.ToInt32(Console.ReadLine());
        //Swap<Person>(ref a[x], ref a[y]);

        //foreach (Person p in a)
        //{
        //    p.Output();
        //}

        //Console.WriteLine();
        //int[] ints = new int[n];        //int
        //for (int i = 0; i < n; i++)
        //{
        //    ints[i] = Random.Next();
        //    Console.Write(ints[i] + " ");
        //}
        //Swap<int>(ref ints[x], ref ints[y]);
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write(ints[i] + " ");
        //}

        //Console.WriteLine();
        //double[] doub = new double[n];      //double
        //for (int i = 0; i < n; i++)
        //{
        //    doub[i] = Random.NextDouble();
        //    Console.Write(doub[i] + " ");
        //}
        //Swap<double>(ref doub[x], ref doub[y]);
        //Console.WriteLine();
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write(doub[i] + " ");
        //}


        //string[] str = new string[n];         //string
        //Console.WriteLine("\nВведите строки: ");
        //for (int i = 0; i < n; i++)
        //{
        //    str[i] = Console.ReadLine();
        //}
        //Swap<string>(ref str[x], ref str[y]);

        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine(str[i]);
        //}


        //Random Random = new Random();     //task 1(b)
        //Console.WriteLine("Сколько элементов вы хотите ввести? ");
        //int n = Convert.ToInt32(Console.ReadLine());
        //int[] a = new int[n];
        //Console.WriteLine("Какой элемент хотите удалить?: ");
        //int y = int.Parse(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = Random.Next();
        //    Console.Write(a[i] + " ");
        //}
        //Console.WriteLine();
        //Remove<int>(ref a, ref y);
        //for (int i = 0; i < a.Length; i++)
        //{
        //    Console.Write(a[i] + " ");
        //}


        //Console.WriteLine("Сколько людей вы хотите ввести?: ");    //task2(a)
        //int n = int.Parse(Console.ReadLine());
        //Person[] a = new Person[n];
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = new Person();
        //    a[i].Input();
        //}
        //Console.WriteLine(a[0].CompareTo(a[1]));
        //Array.Sort(a);
        //for(int i=0;i<a.Length; i++)
        //{
        //    a[i].Output();
        //}
        //Push1(a).Output();


        //Console.WriteLine("Сколько людей вы хотите ввести?: ");    //task2(b)
        //int n = int.Parse(Console.ReadLine());
        //Person[] a = new Person[n];
        //for (int i = 0; i < n; i++)
        //{
        //    a[i] = new Person();
        //    a[i].Input();
        //}
        //Array.Sort(a,new Agecomparer());
        //for(int i=0;i<a.Length; i++)
        //{
        //    a[i].Output();
        //}
        //Array.Sort(a, new PlintusComparer());
        //for (int i = 0; i < a.Length; i++)
        //{
        //    a[i].Output();
        //}


        //try            //task 3
        //{
        //    Console.WriteLine(" Введите строку: ");
        //    string str= Console.ReadLine();
        //    Console.WriteLine("Введите число: ");
        //    int g = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Введите десятичное число: ");
        //    double d = double.Parse(Console.ReadLine());
        //    MyTriple<string,int,double> a = new MyTriple<string,int,double>(str,g,d);
        //    Console.WriteLine(a[0]);
        //    Console.WriteLine(a[1]);
        //    Console.WriteLine(a[2]);
        //    Console.WriteLine(a[5]);
        //}
        //catch(IndexOutOfRangeException e)
        //{
        //    Console.WriteLine("Индекс вышел из границ допущенного");
        //}


        //DoublyLinkedList<int> a = new DoublyLinkedList<int>();
        //Console.WriteLine("Введите число: ");
        //int b;
        //string c = Console.ReadLine();
        //while (c != "")
        //{
        //    b = Convert.ToInt32(c);
        //    if (Math.Abs(b) <= 1000)
        //    {
        //        if (a.Count < 2)
        //        {
        //            a.Add(b);
        //        }
        //        else
        //        {
        //            if (Math.Abs(a.GetFirst - b) < Math.Abs(a.GetLast - b))
        //            {
        //                a.AddFirst(b);
        //            }
        //            else { a.Add(b); }
        //        }
        //        Console.WriteLine("Введите число: ");
        //        c = Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine("число должно быть меньше по модулю 1000");
        //    }
        //}
        //Console.WriteLine("Размер: "+ a.Count);
        //Console.WriteLine("Список: "+ a.total());


        DoublyLinkedList<string> a = new DoublyLinkedList<string>();
        Console.WriteLine("Введите строку: ");
        string c = Console.ReadLine();
        while (c != "")
        {
            if (c.Length <= 1000)
            {
                if (a.Count < 2)
                {
                    a.Add(c);
                }
                else
                {
                    if (Math.Abs(a.GetFirst.Length - c.Length) < Math.Abs(a.GetLast.Length - c.Length))
                    {
                        a.AddFirst(c);
                    }
                    else { a.Add(c); }
                }
                Console.WriteLine("Введите строку: ");
                c = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Длина строки должна быть меньше 1000");
            }
        }
        Console.WriteLine("Размер: " + a.Count);
        Console.WriteLine("Список: " + a.total());


        static Person Push1(Person[] a)
        {
            Person max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max.CompareTo(a[i]) < 0)
                {
                    max = a[i];
                }
            }
            return max;
        }
        void Remove<T>(ref T[] x, ref int y)
        {
            T[] tmp = new T[x.Length - 1];
            for (int i = 0; i < y; i++)
            {
                tmp[i] = x[i];
            }
            for (int i = y + 1; i < x.Length; i++)
            {
                tmp[i - 1] = x[i];
            }
            x = tmp;
        }



        void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}