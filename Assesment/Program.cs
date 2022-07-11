using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    class Program
    {

            #region method overloading
        //class Addition
        //{
        //    public int add(int a, int b)
        //    {
        //        int sum= a + b;
        //        return sum;
        //    }
        //    public int add(int a, int b, int c)
        //    {
        //        int sum = a + b + c;
        //        return sum;
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {

            #region sorted array list
            ArrayList mylist = new ArrayList();
            mylist.Add("Delhi");
            mylist.Add("Mumbai");
            mylist.Add("Kolkata");
            mylist.Add("Chennai");


            Console.WriteLine("Sorted ArrayList");
            mylist.Sort();
            foreach (string i in mylist)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
            #endregion 








            #region methodoverloadingmain
            //Addition addition = new Addition();
            //int sum1 =  addition.add(1, 2);
            //Console.WriteLine("sum of two integer value :" + sum1);

            //int sum2= addition.add(2, 3,4);
            //Console.WriteLine("sum of three integer value :" + sum2);

            //Console.ReadKey();

            #endregion



            #region even-odd
            //int size, even, odd;
            //int[] arr;

            
            //Console.Write("Enter size of the array: ");
            //size = Convert.ToInt32(Console.ReadLine());

            
            //Console.WriteLine("Enter {0} elements in array:", size);

            //arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Number({0}) :", i + 1);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            
            //even = 0;
            //odd = 0;
            //for (int i = 0; i < size; i++)
            //{
            
            //    if (arr[i] % 2 == 0)
            //    {
            //        even++;
            //    }
            //    else
            //    {
            //        odd++;
            //    }
            //}

            //Console.Write("Total even elements: {0}\n", even);
            //Console.Write("Total odd elements: {0}", odd);

            //Console.ReadLine();
            #endregion


            #region count

            //int size, n;
            //int[] arr;


            //Console.Write("Enter size of the array: ");
            //size = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Enter {0} elements in array:", size);

            //arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Number({0}) :", i + 1);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //n = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    n++;
            //}

            //Console.Write("Total number of elements: {0}\n", n);


            //Console.ReadLine();

            #endregion


            #region count od odd numbers
            //Console.WriteLine("Odd numbers from 1 to 10.");

            //for (int n = 1; n <= 10 ; n++)
            //{
            //    if (n % 2 != 0)
            //    {
            //        Console.WriteLine(n);
            //    }
            //}
            //Console.ReadKey();

            #endregion




        }
    }
}
