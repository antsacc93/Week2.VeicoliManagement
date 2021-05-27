using System;
using System.Collections;

namespace Week2.GestioneAutomobili
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList veicoli = new ArrayList();
            bool continua = true;
            while (continua)
            {
                int scelta = SchermoMenu();

                switch (scelta)
                {
                    case 1:
                        Veicolo veicoloDaAggiungere = VeicoliManagement.InserisciVeicolo();
                        veicoli.Add(veicoloDaAggiungere);
                        break;
                    case 2:
                        VeicoliManagement.StampaVeicoli(veicoli);
                        break;
                    case 3:
                        Veicolo veicoloDaCancellare = VeicoliManagement.CercaVeicolo(veicoli);
                        try
                        {
                            veicoli.Remove(veicoloDaCancellare);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Veicolo non trovato");
                            
                        }
                        
                        break;
                    case 4:
                        VeicoliIO.StampaSuFile(veicoli);
                        break;
                    case 0: //casistica dell'eccezione
                        break;
                    default: //un numero diverso da 0
                        continua = false;
                        Console.WriteLine("Arrivederci");
                        break;
                }
            }

        }

        public static int SchermoMenu()
        {
            Console.WriteLine("1. Inserisci veicolo");
            Console.WriteLine("2. Stampa veicoli");
            Console.WriteLine("3. Elimina veicolo");
            Console.WriteLine("4. Stampa su file");
            Console.WriteLine("5. Per uscire");
            int scelta = 0;
            try
            {
                scelta = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Inserisci un numero corretto");
                scelta = 0;
            }
            return scelta;
        }
    }
}
