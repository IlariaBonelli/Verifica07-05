using ElencoSpese.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace ElencoSpese
{
    class Program
    {

        static void Main(string[] args)
        {
            FileSystemWatcher fsw = new FileSystemWatcher();
            fsw.Path = @"C:\Users\ilaria.bonelli\source\repos\ElencoSpese";
            fsw.Filter = "spese.txt";
            fsw.NotifyFilter = NotifyFilters.LastWrite;
            fsw.EnableRaisingEvents = true;
            fsw.Created += GestioneEvento.GestioneFile;
            Console.WriteLine("Inserisci q per chiudere il programma");
            while (Console.Read() != 'q') ;

            Console.WriteLine("Chain of Responsibility");

            var manager = new ManagerHandler();
            var opmanager = new OpManagerHandler();
            var ceo = new CEOHandler();

            manager.SetNext(opmanager).SetNext(ceo);
            List<Spesa> spese = new List<Spesa>();





        }
    }
}
