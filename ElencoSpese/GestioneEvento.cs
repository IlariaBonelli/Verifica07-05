using ElencoSpese.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElencoSpese
{
    public class GestioneEvento
    {
       
        public static void GestioneFile(object sender, FileSystemEventArgs e)
        {
           
            using StreamReader reader = File.OpenText(e.FullPath);
            List<Spesa> spese = new List<Spesa>();

            string line;
            while ((line= reader.ReadLine()) != null)
            {
                string[] values = line.Split(",");
                Spesa spesa = new Spesa();
                spesa.Data = DateTime.Parse(values[3]);
                spese.Add(spesa);
            }
           
            Console.WriteLine("Factory delle spese");
            foreach (Spesa spesa in spese)
            {
                IRimborso rimborso = FactorySpese.Rimborso(spesa.Categoria);
                spesa.Rimborso = rimborso.GeneraRimborso(spesa.Importo);
            }


            string path = @"C:\Users\ilaria.bonelli\source\repos\ElencoSpese\spese.txt";
            using StreamWriter writer = File.CreateText(path);

            foreach (Spesa approvaz in spese)
            {
                if (approvaz.Approvato)
                {

                }
                else
                {

                }

                writer.Close();
            }
        }

    }
}