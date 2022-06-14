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

            //Test af ToString i BadetidsPeriode
            BadetidsPeriode b = new BadetidsPeriode("Morgendukkert", DayOfWeek.Wednesday, new DateTime().AddHours(6).AddMinutes(30), new DateTime().AddHours(7).AddMinutes(30), new Dictionary<string, Kreds>());
            //Console.WriteLine(b);

            //Test af CRUD metoder
            b.AdderKreds(k);
            b.AdderKreds(kredsen);
            b.SletterKreds("1");
            Console.WriteLine("kreds 1 er nu slettet");
            Console.WriteLine(b);

        }
    }
}
