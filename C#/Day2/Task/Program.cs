using System.Diagnostics;
using System.Linq;

namespace Day2SD43_Task1
{
    internal class Program
    {

        public static int calcDistance(int[] arr)
        {
            int longestDistance=0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        if ((j - i) - 1 > longestDistance)
                            longestDistance = j - i - 1;
                    }
                }
            }



            return longestDistance;
        }

        public static void ReverseString(string str)
        {
            Console.WriteLine(string.Join(" ", str.Split(" ").Reverse().ToArray()));

        }
        /// <summary>
        /// we will convert the i into string and split on 1 and calc the array length -1
        /// </summary>
        /// <returns></returns>
        public static int calcOnesV1()
        {
            int counter = 0;
            for (int i = 0; i <=Math.Pow(10,8); i++)
            {
                 counter += i.ToString().Split("1").Length - 1;
            }
            

            return counter;
        }
        
        public static double calcOnesV2()
        {
            //n*10(n-1)+1
            return 8 *Math.Pow(10,7)+1;
        }
        
        public static int calcOnesV3()
        {
            string x;
            int counter = 0;
            for (int i = 0; i <=Math.Pow(10,8); i++)
            {
                x = i.ToString();
                if(x.Contains("1"))
                {
                    char[] y = x.ToCharArray();
                    for (int j = 0; j < x.ToCharArray().Length; j++)
                    {
                        if (y[j] == '1')
                            counter++;
                    }
                }


            }

            return counter;
        }
        static void Main(string[] args)
        {

            #region calcLongestDistance
            //int[] arr1 = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            //int[] arr2 = { 1, 1, 1, 1, 1, 1, 1 };
            //int v = calcDistance(arr1);
            //Console.WriteLine(v);
            #endregion


            #region reverseString
            //ReverseString("this is a test");
            //ReverseString("all your base");
            //ReverseString("word");
            #endregion

            //9.5 seconds in the first method
            #region CalcTimeV1
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //Console.WriteLine(calcOnesV1());
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);
            #endregion

            //10ms in the best way
            #region CalcTimeV2
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //Console.WriteLine(calcOnesV2());
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);
            #endregion


            #region v3
            //12sec
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //Console.WriteLine(calcOnesV3());
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);
            #endregion
        }
    }
}