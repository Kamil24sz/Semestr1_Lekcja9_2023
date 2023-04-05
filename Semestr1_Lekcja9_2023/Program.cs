using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja9_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.input pytamy użytkownika jakie wykonujemy działanie
            // 1 z 4 opcji (mnożenie, dzielenie, odejmowanie, dodawanie)

            //2.input prosimy o liczbę a
            //3.input prosimy o liczbę b

            Console.WriteLine("Podaj rodzaj operacji (mnożenie, dzielenie, odejmowanie, dodawanie)");
            string operacja = Console.ReadLine();

            Console.WriteLine("Podaj liczbę a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę b");
            double b = double.Parse(Console.ReadLine());

            double wynik = 0;

            switch (operacja.ToLower()) {
                case "dodawanie":
                    wynik = a + b;
                    break;

                case "odejmowanie":
                    wynik = a - b;
                    break;

                case "mnożenie":
                    wynik = a * b;
                    break;

                case "dzielenie":
                    wynik = a / b;
                    break;

                default:
                    Console.WriteLine("nieprawidłowa nazwa operacji");
                    break;
            }

            Console.WriteLine($"wynik = {wynik}");
            Console.ReadLine();
        }
    }
}
