using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuente1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcolo imposta da versare:\n");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Cognome: ");
            string cognome = Console.ReadLine();

            Console.Write("Data di nascita: ");
            DateTime dataNascita = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Codice Fiscale: ");
            string codiceFiscale = Console.ReadLine();

            Console.Write("Sesso (M/F): ");
            char sesso = char.Parse(Console.ReadLine());

            Console.Write("Comune di residenza: ");
            string comuneResidenza = Console.ReadLine();

            Console.Write("Reddito Annuale: ");
            decimal redditoAnnuale = decimal.Parse(Console.ReadLine());

            Contribuente contribuente = new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);

            decimal impostaDaVersare = contribuente.CalcolaImposta();

            Console.WriteLine("\n riepilogo risultato:");
            Console.WriteLine($"Contribuente: {contribuente.Nome} {contribuente.Cognome},");
            Console.WriteLine($"nato il {contribuente.DataNascita.ToString("dd/MM/yyyy")} ({contribuente.Sesso}),");
            Console.WriteLine($"residente in {contribuente.ComuneResidenza},");
            Console.WriteLine($"codice fiscale: {contribuente.CodiceFiscale}");
            Console.WriteLine($"\nReddito dichiarato: {contribuente.RedditoAnnuale:C}");

            Console.WriteLine($"\nIMPOSTA DA VERSARE: {impostaDaVersare:C}");

            Console.ReadLine();
        }
    }
}
