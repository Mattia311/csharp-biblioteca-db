using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Biblioteca b = new Biblioteca("Civica");



            //b.AggiungiScaffale("SS1");
            //b.AggiungiScaffale("SS2");
            //b.AggiungiScaffale("SS3");

            //b.ScaffaliBiblioteca.ForEach(item => Console.WriteLine(item.Numero));


            Console.WriteLine("INSERISCI UN LIBRO");
            Console.WriteLine("Inserisci il nome dell'autore");
            string nAutore = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome dell'autore");
            string cAutore = Console.ReadLine();
            Console.WriteLine("Inserisci la mail dell'autore");
            string mAutore = Console.ReadLine();

            Console.WriteLine("==========================================");

            Console.WriteLine("Inserisci il titolo del libro");
            string titoloLibro = Console.ReadLine();
            Console.WriteLine("Inserisci il settore del libro");
            string settoreLibro = Console.ReadLine();
            Console.WriteLine("Inserisci il numero di pagine del libro");
            int nPagineLibro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Scegli tra queste liste dove inserire il libro: SS1,SS2,SS3");
            string listaLLibro = Console.ReadLine();

            List<Autore> listaAutori = new List<Autore>();
            Autore autoreMioLibro = new Autore(nAutore, cAutore, mAutore);
            listaAutori.Add(autoreMioLibro);

            b.AggiungiLibro(DB.GetUniqueId(), titoloLibro, settoreLibro, nPagineLibro, listaLLibro, listaAutori);


            //Console.WriteLine("lista operazioni");
            //    Console.WriteLine("\t1: cerca libro per autore");
            //    Console.WriteLine("Cosa vuoi fare");
            //    string sAppo = Console.ReadLine();
            //    while (sAppo != "")
            //    {
            //        b.GestisciOperazioniBiblioteca(Convert.ToInt32(sAppo));
            //    }

            //Libro l1 = new Libro("ISBN1", "Titolo 1", 2009, "Storia", 220);

            //Autore a1 = new Autore("Nome 1", "Cognome 1");
            //Autore a2 = new Autore("Nome 2", "Cognome 2");

            ////Autori.Add(a1);
            ////Autori.Add(a2);

            ////Scaffale = s1;

            ////b.Documenti.Add(l1);


            //#region "Libro 2"
            //Libro l2 = new Libro("ISBN2", "Titolo 2", 2009, "Storia", 130);

            //Autore a3 = new Autore("Nome 3", "Cognome 3");
            //Autore a4 = new Autore("Nome 4", "Cognome 4");

            //l2.Autori.Add(a3);
            //l2.Autori.Add(a4);

            ////l2.Scaffale = s2;
            ////b.Documenti.Add(l2);
            //#endregion

            //#region "DVD"
            //DVD dvd1 = new DVD("Codice1", "Titolo 3", 2019, "Storia", 130);

            //dvd1.Autori.Add(a3);

            ////dvd1.Scaffale = s3;
            ////b.Documenti.Add(dvd1);
            //#endregion

            //Utente u1 = new Utente("Nome 1", "Cognome 1", "Telefono 1", "Email 1", "Password 1");

            ////b.Utenti.Add(u1);

            //Prestito p1 = new Prestito("P00001", new DateTime(2019, 1, 20), new DateTime(2019, 2, 20), u1, l1);
            //Prestito p2 = new Prestito("P00002", new DateTime(2019, 3, 20), new DateTime(2019, 4, 20), u1, l2);

            ////b.Prestiti.Add(p1);
            ////b.Prestiti.Add(p2);

            //Console.WriteLine("\n\nSearchByCodice: ISBN1\n\n");

            //List<Documento> results = b.SearchByCodice("ISBN1");

            //foreach (Documento doc in results)
            //{
            //    Console.WriteLine(doc.ToString());

            //    if (doc.Autori.Count > 0)
            //    {
            //        Console.WriteLine("--------------------------");
            //        Console.WriteLine("Autori");
            //        Console.WriteLine("--------------------------");
            //        foreach (Autore a in doc.Autori)
            //        {
            //            Console.WriteLine(a.ToString());
            //            Console.WriteLine("--------------------------");
            //        }
            //    }
            //}

            //Console.WriteLine("\n\nSearchPrestiti: Nome 1, Cognome 1\n\n");

            //List<Prestito> prestiti = b.SearchPrestiti("Nome 1", "Cognome 1");

            //foreach (Prestito p in prestiti)
            //{
            //    Console.WriteLine(p.ToString());
            //    Console.WriteLine("--------------------------");
            //}



        }
    }
}
