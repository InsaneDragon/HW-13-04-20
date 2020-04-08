using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = new int[8] { 1, 2, 3, 4, 5, 6, 7, 7 };
            int n = ArrayHelper.Pop(ref b);
            System.Console.WriteLine(n);
            
        }
        public class ArrayHelper
        {
            public static int Pop(ref int[] list)
            {
                int a = list[list.Length - 1];
                int[] b = new int[list.Length - 1];
                for (int i = 0; i < list.Length - 1; i++) b[i] = list[i];
                list = b;
                return a;
            }
            public static double Pop(ref double[] list)
            {
                double a = list[list.Length - 1];
                double[] b = new double[list.Length - 1];
                for (int i = 0; i < list.Length - 1; i++) b[i] = list[i];
                list = b;
                return a;
            }
            public static decimal Pop(ref decimal[] list)
            {
                decimal a = list[list.Length - 1];
                decimal[] b = new decimal[list.Length - 1];
                for (int i = 0; i < list.Length - 1; i++) b[i] = list[i];
                list = b;
                return a;
            }
            public static float Pop(ref float[] list)
            {
                float a = list[list.Length - 1];
                float[] b = new float[list.Length - 1];
                for (int i = 0; i < list.Length - 1; i++) b[i] = list[i];
                list = b;
                return a;
            }
        }
    }
}