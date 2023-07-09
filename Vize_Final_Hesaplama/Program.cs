using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_Final_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Açıklama :  Girilen vize ve final sonuçarına göre o dersin ortalamasını hesaplama");

            Console.WriteLine();

            Console.Write("Lütfen isminizi giriniz : ");
            string name = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Lütfen soyadınızı giriniz : ");
            string lastname = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Lütfen okuduğunuz bölümü giriniz : ");
            string chapter = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Lütfen hesaplamak istediğiniz bölünün dersini giriniz : ");
            string lesson = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("Lütfen vize notunuzu giriniz : ");
            double visa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Lütfen final notunuzu giriniz : ");
            double final = Convert.ToDouble(Console.ReadLine());

            double visa_calculation = visa * 40 / 100;

            Console.WriteLine("");

            double final_calculation = final * 60 / 100;

            double conclusion = visa_calculation + final_calculation;

            if (conclusion >= 40)
            {

                Console.Write("Dersten başarıyla geçtiniz ve ders ortalaması : " + conclusion);
            }
            else
            {

                Console.Write("Derste başarısız oldunuz  ve ders ortalamanız : " + conclusion);
            }
            Console.ReadLine();



        }
    }
}
