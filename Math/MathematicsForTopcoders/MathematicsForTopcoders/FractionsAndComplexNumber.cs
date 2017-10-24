using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsForTopcoders
{
    public struct Fraction
    {
        public int Numerator;
        public int Denominator;
    }

    public struct ComplexNumber
    {
        public double RealPart;
        public double ImaginaryPart;
    }

    public class FractionsAndComplexNumber
    {
        public Fraction MultiplyFractions(Fraction a, Fraction b)
        {
            Fraction result = new Fraction();
            result.Numerator = a.Numerator * b.Numerator;
            result.Denominator = a.Denominator * b.Denominator;
            return result;
        }

        public Fraction AddFractions(Fraction a, Fraction b)
        {
            GCDandLCM gCDandLCM = new GCDandLCM();
            int denominator = gCDandLCM.LeastCommonMultiple(a.Denominator, b.Denominator);
            Fraction result = new Fraction()
            {
                Denominator = denominator,
                Numerator = ((denominator / a.Denominator) * a.Numerator) + ((denominator / b.Denominator) * b.Numerator)
            };
            return result;
        }

        public Fraction ReduceFraction(Fraction a)
        {
            GCDandLCM gCDandLCM = new GCDandLCM();
            int b = gCDandLCM.EuclidGreatestCommonDivisor(a.Numerator, a.Denominator);
            a.Denominator /= b;
            a.Numerator /= b;
            return a;
        }

        public ComplexNumber AddComplexNumber(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber result = new ComplexNumber()
            {
                RealPart = (a.RealPart + b.RealPart),
                ImaginaryPart = (a.ImaginaryPart + b.ImaginaryPart)
            };
            return result;
        }

        public ComplexNumber MultiplyComplexNumber(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber result = new ComplexNumber()
            {
                RealPart = (a.RealPart * b.RealPart - a.ImaginaryPart * a.ImaginaryPart),
                ImaginaryPart = (a.ImaginaryPart*b.RealPart + a.RealPart*b.ImaginaryPart)
            };
            return result;
        }
    }
}
