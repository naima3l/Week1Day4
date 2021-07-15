using System;
using System.IO;

namespace Week1Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esempio1();

            //Lettura e scrittura da file

            //scrittura del file con chiusura manuale
            StreamWriter sw = new StreamWriter(@"fileProva.txt"); //mi crea questo file nella cartella bean del progetto
            sw.WriteLine("Ciao a tutte!");
            sw.Close();

            string path = @"C:\Users\naima.el.khattabi\source\repos\Week1Day4\Week1Day4\fileProva.txt";
            StreamWriter sw1 = new StreamWriter(path);
            sw1.WriteLine("Ciao a tutte!!!!!!");
            sw1.Close();


            ////scrittura del file con chiusura automatica -> using 
            string path1 = @"C:\Users\naima.el.khattabi\source\repos\Week1Day4\Week1Day4\fileProva1.txt";

            //using (StreamWriter sw2 =  new StreamWriter(path1))
            //{
            //    sw2.WriteLine("Bonjour!");
            //}

            ////Scrittura su file sovrascrivendo il contenuto precedente
            //using(StreamWriter sw2 = new StreamWriter(path1))
            //{
            //    sw2.WriteLine("come state?");
            //}

            ////Scrittura su file mantendendo il contenuto precedente
            //using(StreamWriter sw2 = new StreamWriter(path1,true))
            //{
            //    sw2.WriteLine("Bene, grazie!");
            //}

            //Lettura di tutto il file
            using(StreamReader sw2 = new StreamReader(path1))
            {
                string contenutoFile = sw2.ReadToEnd();
            }

            //Lettura di una riga del file
            using (StreamReader sw2 = new StreamReader(path1))
            {
                string contenutoRiga = sw2.ReadLine();
            }

            //Lettura di tutto il file e divisione del file in righe
            using(StreamReader sw2 = new StreamReader(path1))
            {
                string contenutoFile = sw2.ReadToEnd();
                string[] arrayRighe = contenutoFile.Split("\r\n");
            }



        }

        private static void Esempio1()
        {
            //operatore ternario
            int a = 1, b = 2;

            string c;

            if (a < b)
            {
                c = "a è più piccolo di b";
            }
            else
            {
                c = "a è più grande di b";
            }

            c = (a < b) ? "a è più piccolo di b" : "a è più grande di b";

            //operatore ternario senza assegnazione

            int pari = 0, dispari = 0, n = 10;

            ((n % 2 == 0) ? ref pari : ref dispari)++;

            //Resize array

            int[] myArray = new int[10];
            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{myArray[i]} \t");
            }

            Console.WriteLine("\nStampa del mio array dopo il resize");
            Array.Resize(ref myArray, 3);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]} \t");
            }

            Console.WriteLine("\n");
            //foreach
            foreach (var item in myArray)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
