using System;
using System.IO;

namespace Week1Day4.esercizio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrivere un programma che permetta all'utente di creare la sua lista della spesa.

            //Si chiede all'utente quanti prodotti vuole inserire nell'elenco. (numero intero valido e positivo).
            //Quindi si chiede all'utete di inserire i prodotti (esempio "uova", "pasta"..).
            //Non si possono inserire 2 prodotti uguali.
            //(Opzionale: "uova", "UOVA", "Uova" sono da intendersi uguali, quindi no-case-sensitive)

            //Se l'utente inserisce un prodotto già presente, gli si mostra un messaggio del tipo "prodotto già inserito".
            //Completato l'elenco della spesa, stampare un riepilogo con tutti i prodotti che ha inserito l'utente.

            //Requisiti: utilizzare un array (non una lista). Utilizzare le routine (es. ScriviListaSpesa e StampaListaSpesa)

            //Opzionale. Stampare la lista della spesa su un file "listaSpesa.txt" invece che a video.
            Console.WriteLine("Benvenuto! Quanti prodotti vuoi inserire nell'elenco?");
            int num;
            while(!int.TryParse(Console.ReadLine(), out num) || num < 0)
            {
                Console.WriteLine("Scelta non valida. Devi inserire un numero intero e > 0. Riprova!");
            }

            CaricaSpesa(num);
            
        }

        private static void StampaSpesaFile(string[] s)
        {
            using (StreamWriter sw2 = new StreamWriter(@"listaSpesa.txt"))
            {
                for (int i = 0; i < s.Length; i++)
                {
                    sw2.Write($"{s[i]} \t");
                }
            }
        }

        private static void StampaSpesaVideo(string[] s)
        {
            Console.WriteLine("La tua lista della spesa e':");
            for(int i = 0; i < s.Length; i++)
            {
                Console.Write($"{s[i]} \t");
            }
        }

        private static void CaricaSpesa(int num)
        {
            int i = 0, found;
            Console.WriteLine("Perfetto! Adesso inserisci i prodotti");
            string[] carrello = new string[num];
            string product;
           for(i = 0; i < num; i++)
            {
                Console.WriteLine($"Inserisci il {i + 1}° prodotto");
                product = Console.ReadLine().ToUpper();
                found = Array.IndexOf(carrello, product);
                if (found > -1)
                {
                    Console.WriteLine("Il prodotto scelto è già stato inserito!");
                    i--;
                }
                else
                {
                    carrello[i] = product;
                    

                }
            }
            StampaSpesaVideo(carrello);
            StampaSpesaFile(carrello);
        }
    }
}
