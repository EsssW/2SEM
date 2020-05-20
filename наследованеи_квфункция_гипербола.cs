using System;

namespace HW_FUNCTION_IN_PIOINT
{
    class Program
    {
        public abstract class Function
        {   
            public  string type { get; set; }
            public  double a { get; set; }
            public double b{ get; set; }

            public Function() { a = 0;b = 0;type = ""; }
            public Function(double a, double b,string s) 
            {  
                this.a = a;
                this.b = b; 
                this.type = s;
            }

            public abstract double Valume(double x);
            public virtual void Display()
            {
                Console.WriteLine("Funtion type: " + type) ;
            }
            
        }
        public class SqFunction : Function
        {
            public double c { get; set; }
            public SqFunction() : base(0, 0, "Квадратичная функция") { }
            public SqFunction(double a,double b,double cc) :base(a,b, "Квадратичная функция")
            {
                this.c = cc;
            }
            double res;
            double xx;
            public override double Valume(double x)
            {
                xx = x;
                res= Math.Pow(x, 2) * a + x * b + c;
                return res;
            }
            public override void Display() 
            {
                Console.WriteLine("===============================");
                base.Display();
                Console.WriteLine("A= {0}\nB= {1}\nC={2}",a,b,c);
                Console.WriteLine("F({0})= {1}",xx,res);
            }
        }
        public class Hyperbola : Function
        {
            public double a { get; set; }
            public double b { get; set; }
            public Hyperbola() : base(0, 0, "Гиперболическая Функция") { }
            public Hyperbola(double x) : base(x, 0, "Гиперболическая Функция") { }
            double res;
            double xx;
            public override double Valume(double x)
            {
                xx = x;
                res = 1 / x;
                return res; 
            }
            public override void Display()
            {
                Console.WriteLine("===============================");
                base.Display();
                Console.WriteLine("A= {0}\nB= {1}", a, b);
                Console.WriteLine("F({0})= {1}", xx, res);
            }

        }
        static void Main(string[] args)
        {
            int SORTF (Function a,Function b,double x)
            {
                if (a.Valume(x) > b.Valume(x)) return 1;
                if (a.Valume(x) == b.Valume(x)) return 0;
                else  return -1;
            }
            Function[] f =
            {
                new SqFunction(1,2,1),
                new Hyperbola(3),
                new SqFunction(2,2,2),
                new Hyperbola(22)
            };
            foreach (Function i in f)
                i.Display();
            Console.WriteLine("###################");
            Console.WriteLine("Введите точку X для сортировки");
            double point = Convert.ToDouble(Console.ReadLine());
            
            Function exp;
            for (int i = 0; i < f.Length; i++)
            {
                for (int j = i + 1; j < f.Length; j++)
                {
                    if (f[i].Valume(point) > f[j].Valume(point))
                    {
                        exp = f[i];
                        f[i] = f[j];
                        f[j] = exp;
                    }
                }
            }
            foreach (Function i in f)
                i.Display();
        }
    }
}
