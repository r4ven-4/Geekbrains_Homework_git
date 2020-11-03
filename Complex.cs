namespace HomeWork_3
{
    struct Complex
    {
        double b; // imaginary
        double a; // real        
        public Complex(double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.b = x2.b + this.b;
            x3.a = x2.a + this.a;
            return x3;
        }

        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.b = x2.b - this.b;
            x3.a = x2.a - this.a;
            return x3;
        }

        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.b = this.a * x2.b + this.b * x2.a;
            x3.a = this.a * x2.a - this.b * x2.b;
            return x3;
        }
        public string ToString()
        {
            return a + " " + b + "i";
        }

        public double B
        {
            get { return b; }
            set
            {
                if (value >= 0) b = value;
            }
        }


    }
}
