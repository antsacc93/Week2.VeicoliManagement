using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.GestioneAutomobili
{
    public static class VeicoliIO
    {
        public static void StampaSuFile(ArrayList veicoli)
        {
            string path = Path.Combine(Environment
                .GetFolderPath(Environment.SpecialFolder.Desktop),
                "veicoli2.txt");
            try
            { 
                using(StreamWriter writer = File.CreateText(path))
                {
                    foreach(Veicolo veicolo in veicoli)
                    {
                        writer.WriteAsync(veicolo.ToString());
                    }
                    
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
