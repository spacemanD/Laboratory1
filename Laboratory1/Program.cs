using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ConsoleApp5
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements in set A: ");
            int A = int.Parse(Console.ReadLine());
            double[] setA = new double[A];

            for (int i = 0, a = 1; i < setA.Length; i++, a++)
            {
                Console.Write("\n Enter " + (a) + " element of set A: ");
                 setA[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("\n Enter number of elements in set B: ");
            int B = int.Parse(Console.ReadLine());
            double[] setB = new double[B];
            for (int i = 0, a = 1; i < setB.Length; i++, a++)
            {
                Console.Write("\n Enter " + (a) + " element of set B: ");

                 setB[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("\n Enter number of elements in set C: ");
            int C = int.Parse(Console.ReadLine());
            double[] setC = new double[C];
            for (int i = 0, a = 1; i < setC.Length; i++, a++)
            {
                Console.Write("\n Enter " + (a) + " element of set C: ");

                  setC[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(" For Union AB type 1 " +" \n "+ " For Union BC type 2 " + " \n " + " For Union AC type 3 " + " \n " + " For intersection AB type 4 " + " \n " + " For intersection BC type 5 " + " \n " + " For intersection AC type 6 " + " \n " + " For difference A-B type 7" + " \n " + " For difference B-A type 8" + " \n "+ " For difference C-A type 9" + " \n "+ " For difference A-C type 10" + " \n "+" For difference B-C type 11" + " \n " + " For difference C-B type 12" + " \n ");
            while (true)
            {
                int output = int.Parse(Console.ReadLine());
                if (output == 1) Console.WriteLine("Union AB:  " + string.Join(" , ", Union(setA, setB)));
                if (output == 2) Console.WriteLine("Union BC:  " + string.Join(" , ", Union(setB, setC)));
                if (output == 3) Console.WriteLine("Union AC:  " + string.Join(" , ", Union(setA, setC)));
                if (output == 4) Console.WriteLine("Intersection AB:  " + string.Join(" , ", Intersection(setA, setB)));
                if (output == 5) Console.WriteLine("Intersection BC:  " + string.Join(" , ", Intersection(setB, setC)));
                if (output == 6) Console.WriteLine("Intersection AC:  " + string.Join(" , ", Intersection(setA, setC)));
                if (output == 7) Console.WriteLine("Difference A-B:  " + string.Join(" , ", Difference(setA, setB)));
                if (output == 8) Console.WriteLine("Difference B-A:  " + string.Join(" , ", Difference(setB, setA)));
                if (output == 9) Console.WriteLine("Difference C-A:  " + string.Join(" , ", Difference(setC, setA)));
                if (output == 10) Console.WriteLine("Difference A-C:  " + string.Join(" , ", Difference(setA, setC)));
                if (output == 11) Console.WriteLine("Difference B-C:  " + string.Join(" , ", Difference(setB, setC)));
                if (output == 12) Console.WriteLine("Difference C-B:  " + string.Join(" , ", Difference(setC, setB)));
            }
        }
        static double[] Intersection(double[] arr1, double[] arr2)
        {
            Filtr(arr1);
            Filtr(arr2);
            int n = 0;
            double[] intersection = new double[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        intersection[n] = arr1[i];
                        n++;
                    }
                    else
                    {
                    }
                }
            }
            FiltrNull(intersection);
            return intersection;
        }
        static double[] Union(double[] arr1, double[] arr2)
        {
            Filtr(arr1);
            Filtr(arr2);
            int n = 0;
            int b = arr1.Length;
            double[] union = new double[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                union[n] = arr1[i];
                n++;
            }
            for (int j = 0; j < arr2.Length; j++)
            {

                union[b] = arr2[j];
                b++;
            }
            FiltrNull(union);
            return union;
        }
        /*static double[] Difference(double[] arr1, double[] arr2)
        {
            double[] difference = new double[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[j] != arr2[j])
                    {
                        difference[i] = arr1[i];
                    }
                }

            }
            FiltrNull(difference);
            return difference;
        }*/
        static double[] Filtr(double[] arr1)
        {
            double[] filtr = new double[arr1.Length];
            double temp;
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
            return filtr;


        }
        static double[] FiltrNull(double[] arr1)
        {
            double[] filtrnull = new double[arr1.Length];
            var set = new HashSet<double>();
            foreach (var item in arr1)
                if (!set.Add(item))
                    Console.WriteLine(item);
            return filtrnull;
        }





        
    static double [] Difference (double[] arr1,double[] arr2 )
    {
            double[] result = arr1.Except<double>(arr2).ToArray<double>();
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]); 
            }
            return result;
    }



        // пересечение последовательностей
   /*static double [] Intersection (double[] arr1,double[] arr2 )
    {
        var result = arr1.Intersect(arr2);
        foreach (string s in result)
        Console.WriteLine(s);
        return s;
     }
         
    static double [] Intersection (double[] arr1,double[] arr2 )
                // объединение последовательностей
        var result = arr1.Union(arr2);

        foreach (string s in result)
        Console.WriteLine(s);
        return s;
        
    }
            
        */


    }
}

