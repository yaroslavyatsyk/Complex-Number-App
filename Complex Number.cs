using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Number_App
{
    public  class Complex_Number
    {
        private double real;
        private double imaginary;

        public Complex_Number(double real, double imaginary)
        {

            this.real = real;
            this.imaginary = imaginary;
        }
        public double Real { get { return real; } }
        public double Imaginary { get { return imaginary; } }


        public static Complex_Number operator +(Complex_Number a, Complex_Number b)
        {
            var real = a.Real + b.Real;
            var imaginary = a.Imaginary + b.Imaginary;
            return new Complex_Number(real, imaginary);
        }

        public static Complex_Number operator -(Complex_Number a, Complex_Number b)
        {
            var real = a.Real - b.Real;
            var imaginary = a.Imaginary - b.Imaginary;
            return new Complex_Number(real, imaginary);
        }

        public static Complex_Number operator *(Complex_Number a, Complex_Number b)
        {
            var real = a.Real * b.Real - a.Imaginary * b.Imaginary;
            var imaginary = a.Real * b.Imaginary + a.Imaginary * b.Real;
            return new Complex_Number(real, imaginary);
        }

        public static Complex_Number operator /(Complex_Number a, Complex_Number b)
        {

            if(b.Real == 0 && b.Imaginary == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            var real = (a.Real * b.Real + a.Imaginary * b.Imaginary) / (Math.Pow(b.Real, 2) + Math.Pow(b.Imaginary, 2));
            var imaginary = (a.Imaginary * b.Real - a.Real * b.Imaginary) / (Math.Pow(b.Real, 2) + Math.Pow(b.Imaginary, 2));
            return new Complex_Number(real, imaginary);
        }
    }
}
