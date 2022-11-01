using System;
using System.Collections.Generic;



namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentException();
            }
            int sum = 0;
            double mean = 0.0;



            foreach (int number in numbers)
            {
                sum += number;
            }



            mean = (double)sum / numbers.Count;
            return mean;
        }



        public double Median(List<int> numbers)
        {



            numbers.Sort();
            
            if (numbers.Count % 2 == 0)
            {
                return (double)(numbers[(int)numbers.Count / 2] + numbers[((int)numbers.Count / 2) - 1]) / 2;
            }
            

            else
            {
                return numbers[(int)Math.Floor((double)numbers.Count / 2)];
            }




        }




    }
}