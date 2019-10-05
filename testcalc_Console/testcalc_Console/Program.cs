using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcalc_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //PERNYATAAN VARIABEL
            int angka1;
            int angka2;
            string opr;
            float ans;
            string yn;

            Console.WriteLine("== KALKULATOR SANGAT SEDERHANA ==");

        //INPUT KALKULATOR
           kalkulator:
            Console.Write("Masukkan angka : ");
            angka1 = int.Parse(Console.ReadLine());

            Console.Write("Masukkan operasi (+, -, /, *) : ");
            opr = Console.ReadLine();

            Console.Write("Masukkan angka 2 : ");
            angka2 = int.Parse(Console.ReadLine());

            //SWITCH CASE LOGIC OPERATOR
            switch (opr)
            {
                case "-":
                    ans = angka1 - angka2;
                    break;
                case "+":
                    ans = angka1 + angka2;
                    break;
                case "*":
                    ans = angka1 * angka2;
                    break;
                case "/":
                    ans = angka1 / angka2;
                    break;
                default:
                    ans = 0;
                    break;
            }

            //HASIL RESULT
            Console.WriteLine("Hasil :");
            Console.WriteLine(angka1 + " " + opr + " " + angka2 + " = " + ans);

            //REPETISI
            Console.WriteLine("Apakah anda ingin menghitung lagi? (Y/N)");
            yn = Console.ReadLine();
            if (yn == "Y" || yn == "y")
            {
                goto kalkulator;

            }
            else if(yn == "N" || yn == "n") {
                Console.WriteLine("== PERHITUNGAN SELESAI ==");
            }

            Console.ReadKey();
        }
    }
}
