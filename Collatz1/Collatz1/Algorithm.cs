using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz1
{
    public class Algorithm
    {
        public int GetNumOfIterations(int n)
        {
            try
            {
                if (n > 1)
                {
                    int timeOutSteps = 0;
                    int timeOutValue = 10000;
                    int numOfSteps = 0;

                    while(n != 1)
                    {
                        if(timeOutSteps > timeOutValue)
                        {
                            break;
                        }
                        if (n % 2 == 0)
                        {
                            n = n / 2;
                        }
                        else
                        {
                            n = 3 * n + 1;
                        }

                        timeOutSteps++;
                        numOfSteps++;
                    }
                    return numOfSteps;
                }
                else return 0;
            }
            catch(Exception e)
            {
                throw;
            }
        }

        public string CalculateCoefficientEquation(string coefficient, long order)
        {
            long slope = 0;
            long intercept = 0;
            switch (coefficient)
            {
                case "A":
                    slope = CalculateASlope(order);
                    intercept = CalculateAIntercept(order);
                    break;
                case "B":
                    slope = CalculateBSlope(order);
                    intercept = CalculateBIntercept(order);
                    break;
                case "C":
                    slope = CalculateCSlope(order);
                    intercept = CalculateCIntercept(order);
                    break;
                default:
                    break;
            }
            return $"{slope}k + {intercept}";
        }
        public void FindAllIterations(int n)
        {
            try
            {
                for(var i = 2; i < n; i++)
                {
                    var numOfSteps = GetNumOfIterations(i);
                    //Write to csv? I'm not sure
                }
            }
            catch(Exception e)
            {
                throw;
            }
        }

        public int FindSetIterations(List<int> setList)
        {
            var result = new List<int>();
            foreach(var n in setList)
            {
                var numOfSteps = GetNumOfIterations(n);
                result.Add(numOfSteps); 
            }

            if(result.Distinct().Count() > 1)
            {
                throw new InvalidOperationException();
            }

            return result.Distinct().FirstOrDefault();
        }

        public List<int> GetSetValues(int numOfTerms, int slope, int intercept)
        {
            var result = new List<int>();

            for(var i = 0; i < numOfTerms; i++)
            {
                result.Add(i * slope - intercept);
            }

            return result;
        }

        public long CalculateASlope(long n)
        {
            var result = 12 * (long)Math.Pow(3, n - 1); 
            return result;
        }

        public long CalculateAIntercept(long n)
        {
            var result = (12 * (long)Math.Pow(3, n - 1)) - 2;
            return result;
        }

        public long CalculateBSlope(long n)
        {
            var result = (12 * (long)Math.Pow(3, n - 1));
            return result;
        }

        public long CalculateBIntercept(long n)
        {
            var result = (6 * (long)Math.Pow(3, n - 1)) - 2;

            return result;
        }

        public long CalculateCSlope(long n)
        {
            var result = 24 * (long)Math.Pow(2, n - 2); 
            return result;
        }

        public long CalculateCIntercept(long n)
        {
            var result = (12 * (long)Math.Pow(2, n - 2)) - 2;
            return result;
        }


    }
}
