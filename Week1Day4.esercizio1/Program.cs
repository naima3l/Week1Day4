using System;

namespace Week1Day4.esercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gioco del lancio dei Dadi



            //Si chiede all'utente quanti dadi vuole lanciare.
            //L'utente inserisce un numero per provare ad indovinare
            //la somma dei valori usciti dal lancio dei dadi.
            //Il computer lancia i dadi, quindi sorteggia i numeri(random tra 1 e 6).
            //Se la somma dei due numeri random è pari al numero scelto dall'utente, l'utente vince
            //Se l'utente vince, stampare 'hai vinto', altrimenti 'hai perso'.
            //Finita la partita, l'utente deve poter rigiocare.
            //Requisiti:
            //Verificare che l'utente inserisca un intero e che sia compreso tra i valori possibili/accettabili.
            //Se la verifica non va a buon fine, l'utente deve potere inserire nuovamente qualcosa.
            //Opzionale->Creare un metodo per l'inserimento dei numeri e la verifica,
            //uno per il controllo della vittoria(da chiamare nel main).

            Menu();

        }

        private static void Menu()
        {
            Console.WriteLine("Benvenuto! Scegli l'opzione. \n1. Lancio dei dadi \n2. Exit");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Scelta non valida. Devi inserire 1 per giocare o 2 per uscire. Riprova!");
            }
            Console.WriteLine($"{choice}");
            if (choice == 1)
            {
                InserimentoEverifica();
            }
            else Console.WriteLine("Ciao ciao!");
        }
        private static void InserimentoEverifica()
        {
            Console.WriteLine("Quanti dadi vuoi tirare?");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <=0)
            {
                Console.WriteLine("Scelta non valida. Devi inserire un numero itero. Riprova!");
            }
            Console.WriteLine("Ottimo! Adesso prova ad indovinare il numero");

            int guess = 0;
            while (!int.TryParse(Console.ReadLine(), out guess) || guess > (6*n))
            {
                Console.WriteLine($"Scelta non valida. Devi inserire un numero itero e non più grande di {(6*n)}. Riprova!");
            }

            Random random = new Random();
            int[] val_dadi = new int[n];
            int sum_dadi = 0;
            for(int i = 0; i < n; i++)
            {
                val_dadi[i] = random.Next(1, 6);
                sum_dadi += val_dadi[i];
                Console.WriteLine($"{i+1}°Lancio : il dado ha restituito il numero {val_dadi[i]}");
            }

            
            String answer = (guess == sum_dadi) ? "Bravissimo! Hai indovinato" : $"Mi dispiace, hai perso. La somma dei dadi era {sum_dadi}";
            Console.WriteLine($"{answer}");
            Menu();
            

        }
    }
}
