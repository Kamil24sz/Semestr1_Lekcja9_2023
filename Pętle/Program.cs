using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pętle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FOR
            // 1 element - przypisujemy zmienną - liczba którą przypiszemy jest startową
            // 2 element - wyrażenie logiczne - do kiedy ma się wykonywać pętla
            // 3 element - o ile ma się zmieniać zmienna sterująca

            for (int x = 0; x <= 100; x++)  // x++ to to samo co x = x + 1
            {  
                    Console.WriteLine(x);
            }

            Console.Clear();

            //Napisać program w konsoli, który będzie wyświetlać wszystkie kolejne liczby
            //podzielne przez 17 od 1 do 5000.

            for(int x = 1; x <= 5000; x++)
            {
                if(x % 17 == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.Clear();
            //szybsze rozwiązanie
            for(int x = 17; x <= 5000; x = x + 17)
            {
                Console.WriteLine(x);
            }

            Console.Clear();

            //Ćwiczenie 2:
            //Napisać program w konsoli, który będzie obliczać kolejne potęgi liczby 2.
            // Math.Pow(2,3) => 2 do potęgi 3
            //pytamy użytkownika żeby podał potęge => jak użytkownik poda 7 => wszystkie potęgi liczby 2 od 1 do 7

            Console.WriteLine("Podaj maksymalną potęgę liczby 2");
            int potega = int.Parse(Console.ReadLine());

            for(int x = 1; x <= potega; x++)
            {
                Console.WriteLine($"2 do potęgi {x} = {Math.Pow(2, x)}");
            }

            Console.Clear();

            //Ćwiczenie 3
            //ustalamy zmienną suma ma miec na początku wartość 0          - OK
            //pytamy użytkownika ile chce dodać do siebie liczb            - OK
            //następnie w pętli pytamy go o te liczby i dodajemy do sumy   - OK
            //na końcu wypisujemy sumę                                     - OK

            //ustalamy wartość początkową sumy
            int suma = 0;

            //pytamy usera ile liczb chce do siebie dodać
            Console.WriteLine("Ile chcesz dodać do siebie liczb");

            //przechwytujemy informację o ilości liczb
            int ilość = int.Parse(Console.ReadLine());

            //pętla for z wykorzystaniem informacji od uzytkownika w 2 elemencie
            for(int x = 1; x <= ilość; x++)
            {
                //sprecyzowanie którą liczbę mamy podać wykorzystując zmienną x z pętli for
                Console.WriteLine($"Podaj {x} liczbę:");
                //dodanie do sumy liczby podanej przez użytkownika - wszystko w jednej linii
                suma = suma + int.Parse(Console.ReadLine());
            }

            //wypisanie sumy
            Console.WriteLine($"Suma = {suma}");
            Console.Clear();

            //Ćwiczenie 4 - pętla w pętli
            //wypisz tabliczkę mnożenia za pomocą 2 pętli for 

            for (int y = 1; y <= 10; y++) {

                for (int x = 1; x <= 10; x++)
                {
                    Console.Write(x * y + "\t");
                }

                Console.WriteLine();
            }

            Console.Clear();

            //Ciekawostka - można przechodzić pętlą po napisach
            string test = "GiganciProgramowania";

            for (int x = 0; x < test.Length; x++)
            {
                Console.WriteLine(test[x]);
            }

            Console.ReadLine();
        }
    }
}
