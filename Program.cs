using System;

namespace array_class_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi);
                Console.Write(" ");
            }
            Console.WriteLine();
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi);
                Console.Write(" ");
            }
            Console.WriteLine();

            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi);
                Console.Write(" ");
            }
            Console.WriteLine();
            
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi);
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(sayi);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}