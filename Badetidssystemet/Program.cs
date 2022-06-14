using System;
using System.Collections.Generic;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Test af ToString i Kreds
            Kreds k = new Kreds("1", "sommerlejr", "Maglegårdsvej", 7, 200);
            //Console.WriteLine(k);
            Kreds kredsen = new Kreds("2", "Vinterlejr", "Maglegårdsvej", 2, 200);
            Dictionary<string, Kreds> kredset = new Dictionary<string, Kreds>();
            //Test af ToString i BadetidsPeriode
            BadetidsPeriode b = new BadetidsPeriode("Morgendukkert", DayOfWeek.Wednesday, new DateTime().AddHours(6).AddMinutes(30), new DateTime().AddHours(7).AddMinutes(30), new Dictionary<string, Kreds>());
            //Console.WriteLine(b);

            //Test af CRUD metoder
            b.AdderKreds(k);
            b.AdderKreds(kredsen);
            b.SletterKreds("1");
            //Console.WriteLine("kreds 1 er nu slettet");
            //Console.WriteLine(b);
            b.Beskrivelse = "Velkommen. Her vil jeg forsøge at lave en beskrivelse til Morgen Dukkert badetidsperioden";
            Console.WriteLine(b);

            //Test af exceptions
            try
            {
                //Kreds kr = new Kreds("3", "efterår", "SørenPetersvej 3", 0);
                //Console.WriteLine(kr);
                BadetidsPeriode c = new BadetidsPeriode("abc", DayOfWeek.Thursday, new DateTime().AddHours(4).AddMinutes(30), new DateTime().AddHours(7).AddMinutes(30), new Dictionary<string, Kreds>());
                Console.WriteLine(c);
                throw new ArgumentException();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            b.ReadKreds();
            BadetidsPeriodeForLoopAndList badetid = new BadetidsPeriodeForLoopAndList("abcde", DayOfWeek.Friday, new DateTime().AddHours(08).AddMinutes(20), new DateTime().AddHours(9).AddMinutes(20), new Dictionary<string, Kreds>(), new List<Kreds>());
            Console.WriteLine(badetid); */
            Kreds k = new Kreds("1", "sommerlejr", "Maglegårdsvej", 7, 200);
            Kreds kredsen = new Kreds("2", "Vinterlejr", "Maglegårdsvej", 2, 200);
            List<Kreds> kreds = new List<Kreds>();
            BadetidsPeriodeForLoopAndList badetid = new BadetidsPeriodeForLoopAndList("abcde", DayOfWeek.Friday, new DateTime().AddHours(08).AddMinutes(20), new DateTime().AddHours(9).AddMinutes(20), new Dictionary<string, Kreds>(), kreds);
            badetid.AdderKreds(kredsen);
            badetid.AdderKreds(k);
            Console.WriteLine(badetid);
        }
    }
}
