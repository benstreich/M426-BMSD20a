using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB; //* summandA
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }
        public int multiplicate(int mulitpliendA, int multipliendB)
        {
            return mulitpliendA * multipliendB;
        }

        public int divide(int dividendA, int dividendB)
        {
            return dividendA / dividendB;
        }
    }
}
