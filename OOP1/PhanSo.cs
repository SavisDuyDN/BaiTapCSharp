using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class PhanSo
    {
        public float numerator { get; set; }
        public float denominator { get; set; }

        public void InputFractions()
        {
            Console.Write("Nhap Vao Tu So: ");
            this.numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Vao Mau So: ");
            this.denominator = Convert.ToInt32(Console.ReadLine());
        }
        public string Add(float numerator, float denominator)
        {
            float analysisNumerator = this.numerator * denominator;
            float analysisDenominator = this.denominator * denominator;
            float analysisNumeratorParams = numerator * this.numerator;
            float analysisDenominatorParams = denominator * this.denominator;
            return (analysisNumerator + analysisNumeratorParams) + "/" + (analysisDenominator);
        }
        public string Minus(float numerator, float denominator)
        {
            float analysisNumerator = this.numerator * denominator;
            float analysisDenominator = this.denominator * denominator;
            float analysisNumeratorParams = numerator * this.numerator;
            float analysisDenominatorParams = denominator * this.denominator;
            return (analysisNumerator - analysisNumeratorParams) + "/" + (analysisDenominator);
        }
        public string Analysis(float numerator, float denominator)
        {
            return (this.numerator * numerator) + "/" + (this.denominator * denominator);
        }
        public string Division(float numerator, float denominator)
        {
            return (this.numerator * denominator) + "/" + (this.denominator * denominator);
        }
    }
}
