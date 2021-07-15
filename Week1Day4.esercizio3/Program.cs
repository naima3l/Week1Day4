using System;

namespace Week1Day4.esercizio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto!");
            Menu();
        }
        private static void Menu()
        {
            Console.WriteLine("Come ti chiami?");
            string name = Console.ReadLine();
            Console.WriteLine($"Ok {name} Scegli l'opzione. \n1. Gioca \n2. Exit");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Scelta non valida. Devi inserire 1 per giocare o 2 per uscire. Riprova!");
            }
            Console.WriteLine($"{choice}");
            if (choice == 1)
            {
                Play();
            }
            else Console.WriteLine("Ciao ciao!");
        }
        private static void Play()
        {
            Random random = new Random();
            int ranNumber= random.Next(1, 100);
            int user_choice, i = 1;
            bool check = false;
            string suggerimento = "";
            Console.WriteLine($"Finora hai effettuato 0 tentativi. \nInserisci il tuo 1° tentativo(0 per interrompere la partita)");

                while (check == false)
                {
                    while (!int.TryParse(Console.ReadLine(), out user_choice))
                    {
                        Console.WriteLine("Scelta non valida. Devi inserire un numero tra 1 e 100 oppure 0 per interrompere. Riprova!");
                    }

                    if (user_choice == 0)
                    {
                        Console.WriteLine($"Hai deciso di interrompere la partita. \nIl numero che avevo scelto era {ranNumber}. \nCiao ciao!");
                    }
                    else if (user_choice == ranNumber)
                    {
                        check = true;
                        break;
                    }
                    else if (user_choice < ranNumber)
                    {
                        suggerimento = "Suggerimento : Inserisci un numero più grande";
                    }
                    else
                    {
                       suggerimento= "Suggerimento : Inserisci un numero più piccolo";
                    }
                    Console.WriteLine($"{suggerimento}");
                    Console.WriteLine($"Finora hai effettuato {i} tentativi. \nInserisci il tuo {i + 1}° tentativo(0 per interrompere la partita)");
                    i++;


            }
                
                 Console.WriteLine($"Bravissimo! Hai indovinato il numero in soli {i} tentativi!");
                
            

            Menu();


        }

    }
    
}
