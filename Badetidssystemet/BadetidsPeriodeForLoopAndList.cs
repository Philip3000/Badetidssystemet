using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class BadetidsPeriodeForLoopAndList : BadetidsPeriode
    {
        Kreds kreds;
        List<Kreds> _kredseList = new List<Kreds>();
        string message;


        public BadetidsPeriodeForLoopAndList(string type, DayOfWeek ugedag, DateTime startTidspunkt, DateTime slutTidspunkt, Dictionary<string, Kreds> kredse, List<Kreds> kredselist)
            : base(type, ugedag, startTidspunkt, slutTidspunkt, kredse)
        {
            _kredseList = kredselist;
        }
        public override void AdderKreds(Kreds kreds)
        {
            for (int i = 0; i < _kredseList.Count; i++)
            {
                AdderKreds(kreds);
            }
        }
        public override void SletterKreds(string id)
        {
            int anotherId = Int32.Parse(id);
            for (int i = 0; i < _kredseList.Count; i++)
            {
                _kredseList.RemoveAt(anotherId);
            }
        }
        public override string ToString()
        {
            Kreds kreds = new Kreds("", "", "", 0, 0);

            for (int i = 0; i < _kredseList.Count; i++)
            {
                _kredseList.Find(_kredseList <kreds> i);
                message += _kredseList;
            }
            return message;

        }
    }
}
