using System;

namespace pz_2_3
{
    class Parallelepiped
    {
        public static int a;
        public int b;
        public int c;
        int v;
        int s;
        public static int schet = 0;//Статический
        public int figura = 0;
        

        public Parallelepiped(int a1, int b1, int c1) //поля класса
        {
            a = a1;
            b = b1;
            c = c1;
            v = a1 * b1 * c1;
            s = 2 * (a1 * b1 + b1 * c1 + a1 * c1);
            Random rnd = new Random();//Чтобы стороны были рандомно от 10 до 100
            if (a1 < 10 || a1 > 100 || b1 < 10 || b1 > 100 || c1 < 10 || c1 > 100)
                a1 = rnd.Next(10, 100);
                b1 = rnd.Next(10, 100);
                c1 = rnd.Next(10, 100);
            //Условия подсчета
            if(a - b >= 50  || b - c >= 50 || a - c >= 50|| c - a  >= 50 || b - a >= 50)
            {
                schet += 1;
            } 
            
        }
        public virtual void GetValue() //метод,который выводит объем и площадь
        {
            
            Console.WriteLine($"ОБЪЕМ фигуры: {v}");
            Console.WriteLine($"ПЛОЩАДЬ фигуры: {s}");
        }
        static void Main(string[] args)
        {
           /* Parallelepiped pr1 = new Parallelepiped(7, 9, 3);
            pr1.GetValue();
            Parallelepiped pr2 = new Parallelepiped(3, 22, 3);
            pr2.GetValue();
            Parallelepiped pr3 = new Parallelepiped(7, 2, 2);
            pr3.GetValue();
            Parallelepiped pr4 = new Parallelepiped(4, 52, 2);
            pr4.GetValue();
            Parallelepiped pr5 = new Parallelepiped(1, 12, 8);
            pr5.GetValue();*/ //Код из прошлой практики

            //Новый код из дочернего класса и переопределенного метода
            Cube pr1 = new Cube(7,9,3, 12);
            pr1.GetValue();
            Cube pr2 = new Cube(3, 22, 3, 42);
            pr2.GetValue();
            Cube pr3 = new Cube(7, 2, 2, 47);
            pr3.GetValue();
            Cube pr4 = new Cube(4, 52, 2, 32);
            pr4.GetValue();
            Cube pr5 = new Cube(1, 12, 8, 87);
            pr5.GetValue();

            Console.WriteLine($"Количество объектов чьи стороны больше на 50: {schet}\n");//подсчет объектов чьи стороны болье 50
        }
        class Cube : Parallelepiped
        {
            public int Ploshad;
            public int Versia2;
            public static int a2 = 0;
            public Cube(int a1, int b1, int c1,int a2) : base(a1, b1, c1)
            {  
                Random rnd = new Random();
                a2 = rnd.Next(1, 99);
                a = a1;
                b = b1;
                c = c1;
                v = a1 * b1 * c1;
                s = 2 * (a1 * b1 + b1 * c1 + a1 * c1);
                Ploshad = 6 * (a2 * a2);//Площадь куба с 1 стороной а2
                Versia2 = a2 * a2 * a2;//Объем куба с 1 стороной а2
                
            }
            public override void GetValue() // переопределяю метод
            {
                base.GetValue();
                Console.WriteLine($"ПЛОЩАДЬ куба: {Ploshad}\nОБЪЕМ куба:{Versia2}\n"); // вывожу в новый метод
            }
        }

    }
}
