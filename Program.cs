using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDD10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] st117 = new int[10];
            for(int i = 0; i< 10; i++)
            {
                Console.Write("Nhap so thu " + (i+1) + ": ");
                st117[i] = int.Parse(Console.ReadLine());
            }
            minMax(st117);
            Console.WriteLine();
            sapXep(st117);

            Console.ReadLine();
        }

        public static void minMax(int[] st117)
        {
            int min117 = st117[0], max117 = st117[0];
            foreach(int a117 in st117)
            {
                if (a117 > max117)
                    max117 = a117;
                if (a117 < min117)
                    min117 = a117;
            }
            Console.WriteLine("Max la: " + max117 + "\nMin la: " + min117);
        }

        public static void count(int[] st117)
        {
            for(int i=0; i<10; i++)
            {

            }
        }

        public static void sapXep(int[] st117)
        {
            int tg;
            for(int i = 0; i<9; i++)
                for(int j=i+1; j<10; j++)
                    if(st117[i]<st117[j])
                    {
                        tg = st117[i];
                        st117[i] = st117[j];
                        st117[j] = tg;
                    }
            Console.Write("Sap xep giam dan: ");
            xuat(st117);

            for (int i = 0; i < 9; i++)
                for (int j = i + 1; j < 10; j++)
                    if (st117[i] > st117[j])
                    {
                        tg = st117[i];
                        st117[i] = st117[j];
                        st117[j] = tg;
                    }
            Console.Write("\nSap xep tang dan: ");
            xuat(st117);
        }
        public static void xuat(int[] st117)
        {
            foreach(int a117 in st117)
            {
                Console.Write(a117 + " ");
            }
        }
    }
}
