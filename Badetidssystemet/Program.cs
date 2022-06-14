using System;
using System.Collections.Generic;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test af ToString i Kreds
            Kreds k = new Kreds("1", "sommerlejr", "Maglegårdsvej", 7);
            //Console.WriteLine(k);
            Kreds kredsen = new Kreds("2", "Vinterlejr", "Maglegårdsvej", 2);
            Dictionary<string, Kreds> kredset = new Dictionary<string, Kreds>();
            //Test af ToString i BadetidsPeriode
            BadetidsPeriode b = new BadetidsPeriode("Morgendukkert", DayOfWeek.Wednesday, new DateTime().AddHours(6).AddMinutes(30), new DateTime().AddHours(7).AddMinutes(30), kredset);
            //Console.WriteLine(b);

            //Test af CRUD metoder
            b.AdderKreds(k);
            b.AdderKreds(kredsen);
            b.SletterKreds("1");
            //Console.WriteLine("kreds 1 er nu slettet");
            //Console.WriteLine(b);

            //Test af exceptions
            try
            {
                //Kreds kr = new Kreds("3", "efterår", "SørenPetersvej 3", 0);
                //Console.WriteLine(kr);
                BadetidsPeriode c = new BadetidsPeriode("Morgendukkert", DayOfWeek.Thursday, new DateTime().AddHours(10).AddMinutes(30), new DateTime().AddHours(7).AddMinutes(30), new Dictionary<string, Kreds>());
                Console.WriteLine(c);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
