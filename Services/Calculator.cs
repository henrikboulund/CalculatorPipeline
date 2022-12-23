using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class Calculator : ICalculator
    {
        public double Add(params double[] numbers)
        {
            var calculation = BasicCalculation(numbers, '+');
            return calculation;
        }

        public double Subtract(params double[] numbers)
        {
            var calculation = BasicCalculation(numbers, '-');
            return calculation;
        }

        public double Multiply(params double[] numbers)
        {
            var calculation = BasicCalculation(numbers, '*');
            return calculation;
        }

        public double Divide(params double[] numbers)
        {
            var calculation = BasicCalculation(numbers, '/');
            return calculation;
        }

        public double Factorial(double number)
        {
            throw new NotImplementedException();
        }
        
        private double BasicCalculation(IReadOnlyList<double> numbers, char operation)
        {
            double result = 0;
            for (var i = 0; i <= numbers.Count - 1; i++)
            {
                if(i == 0)
                {
                    result = numbers[i];
                }
                else
                {
                    switch (operation)
                    {
                        case '+':
                            result = result + numbers[i];
                            break;
                        case '-':
                            result = result - numbers[i];
                            break;
                        case '*':
                            result = result * numbers[i];
                            break;
                        case '/':
                            result = result / numbers[i];
                            break;
                    }
                    
                }
            }
            return result;
        }
    }
}