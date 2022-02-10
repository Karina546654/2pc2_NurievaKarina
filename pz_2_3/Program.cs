using System;

namespace pz_2_3
{
    class Parallelepiped
    {
        public int a;
        public int b;
        public int c;
        int v;
        int s;
       
        public Parallelepiped(int a1, int b1, int c1) //поля класса
        {
            a = a1;
            b = b1;
            c = c1;
            v = a1 * b1 * c1;
            s = 2 * (a1*b1+b1*c1+a1*c1);
        }

        public void GetValue() //метод,который выводит объем
        {
            Console.WriteLine($"ОБЪЕМ: {v}");
        }
        public void GetArea() //метод,который выводит площадь
        {
            Console.WriteLine($"ПЛОЩАДЬ: {s}\n");
        }
        static void Main(string[] args)
        {
            Parallelepiped pr1 = new Parallelepiped(4, 2, 5);
            Parallelepiped pr2 = new Parallelepiped(6, 1, 9);
            Parallelepiped pr3 = new Parallelepiped(36, 52, 15);
            Parallelepiped pr4 = new Parallelepiped(6, 12, 9);
            Parallelepiped pr5 = new Parallelepiped(7, 22, 5);
           

            pr1.GetValue();
            pr1.GetArea();

            pr2.GetValue();
            pr2.GetArea();

            pr3.GetValue();
            pr3.GetArea();

            pr4.GetValue();
            pr4.GetArea();

            pr5.GetValue();
            pr5.GetArea();
        }
    }
}