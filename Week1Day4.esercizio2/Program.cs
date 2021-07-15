using System;

namespace Week1Day4.esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Morra Cinese (carta forbice sasso)



            //Stampare un messaggio di benvenuto al gioco Morra Cinese.
            //Chiedere il NOME dell'utente quindi stampare un messaggio del tipo "Ok NOME, iniziamo a giocare".
            //Il computer sceglie (in modo random) una tra le possibili opzioni tra carta, sasso o forbice.
            //Avvisa l'utente che ha effettuato la sua scelta quindi invita l'utente a fare lo stesso cioè
            //a scegliere una delle 3 opzioni tra quelle disponibili per poter giocare contro di lui.



            //Dopo la scelta dell'utente sarà quindi "calcolato" il vincitore in base al confronto tra le opzioni scelte.
            //Stampare a video un messaggio all'utente che dica se ha vinto, ha perso oppure c'è stato un pareggio.



            //Ricordiamo che:
            //Sasso vince su Forbice
            //Carta vince su Sasso
            //Forbice vince su Carta



            //Al termine del gioco si richiede all'utente se desidera giocare ancora contro il computer.
            //In caso affermativo si ricomincia a giocare,
            //altrimenti si esce dal gioco e deve essere mostrato un messaggio di arrivederci.
            Menu();
        }
        private static void Menu()
        {
            Console.WriteLine("Benvenuto al gioco morra cinese! Scegli l'opzione. \n1. Gioca contro il computer \n2. Exit");
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
            Console.WriteLine("Come ti chiami?");

            string name = Console.ReadLine();
            Console.WriteLine($"Ok {name}, iniziamo a giocare!");
            string[] carte = { "carta", "sasso", "forbice" };
            Random random = new Random();
            int computer_choice = random.Next(1, 3);
            int user_choice;
            string c_choice="", u_choice="";
            switch (computer_choice)
            {
                case 1:
                    c_choice = "carta";
                    break;
                case 2:
                    c_choice = "sasso";
                    break;
                case 3:
                    c_choice = "forbice";
                    break;
            }
            Console.WriteLine("Io ho scelto, adesso tocca a te. Mi raccomando, le opzioni sono \n1. Carta \n2. Sasso \n3. Forbice");
            while (!int.TryParse(Console.ReadLine(), out user_choice))
            {
                Console.WriteLine("Scelta non valida. Devi inserire 1, 2 o 3. Riprova!");
            }
            switch (user_choice)
            {
                case 1:
                    u_choice = "carta";
                    break;
                case 2:
                    u_choice = "sasso";
                    break;
                case 3:
                    u_choice = "forbice";
                    break;
            }

            if(c_choice == "carta" && u_choice == "sasso" || c_choice == "forbice" && u_choice == "carta" || c_choice == "sasso" && u_choice == "forbice")
            {
                Console.WriteLine($"Mi dispiace, hai perso. Ma ricordati che stai giocando contro un computer! Io avevo scelto {c_choice}.");
            }
            else if(c_choice == u_choice)
            {
                Console.WriteLine("Wow, abbiamo avuto la stessa scelta! Ho trovato un giocatore alla mia altezza!");
            }
            else Console.WriteLine($"Ugh, hai vinto contro di me! Io avevo scelto {c_choice} . Congratulazioni!");
            
            Menu();


        }
    }
}
