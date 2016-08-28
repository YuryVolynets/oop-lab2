using System;

namespace lab2
{
    class Triangle
    {
        private int a, b, c;

        public int A
        {
            get { return a; }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    throw new Exception("Сторона треугольника должна иметь положительную длину");
                }
            }
        }

        public int B
        {
            get { return b; }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    throw new Exception("Сторона треугольника должна иметь положительную длину");
                }
            }
        }

        public int C
        {
            get { return c; }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
                else
                {
                    throw new Exception("Сторона треугольника должна иметь положительную длину");
                }
            }
        }

        public bool IsExist
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public int this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return a;
                    case 1:
                        return b;
                    case 2:
                        return c;
                    default:
                        throw new Exception("Недопустимое значение");
                }
            }
        }

        public Triangle(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new Exception("Сторона треугольника должна иметь положительную длину");
            }
        }

        public void Print()
        {
            Console.WriteLine("Длины сторон: {0} {1} {2}", a, b, c);
        }

        public int Perimeter()
        {
            return IsExist ? a + b + c : 0;
        }

        public double Area()
        {
            return IsExist ? Math.Sqrt((a + b + c) * (b + c - a) * (a + c - b) * (a + b - c)) / 4 : 0;
        }

        public static Triangle operator ++(Triangle t)
        {
            return new Triangle(++t.a, ++t.b, ++t.c);
        }

        public static Triangle operator --(Triangle t)
        {
            return new Triangle(--t.a, --t.b, --t.c);
        }

        public static bool operator true(Triangle t)
        {
            return t.IsExist;
        }

        public static bool operator false(Triangle t)
        {
            return t.IsExist;
        }

        public static Triangle operator *(Triangle t, int m)
        {
            return new Triangle(t.a * m, t.b * m, t.c * m);
        }

        public static implicit operator string(Triangle t)
        {
            return t.a + "," + t.b + "," + t.c;
        }

        public static implicit operator Triangle(string s)
        {
            return new Triangle(int.Parse(s.Split(',')[0]), int.Parse(s.Split(',')[1]), int.Parse(s.Split(',')[2]));
        }
    }
}