using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class BadetidsPeriode
    {
        #region Instance
        string _type;
        DayOfWeek _ugedag;
        DateTime _startTidspunkt;
        DateTime _slutTidspunkt;
        string _output;
        Dictionary<string, Kreds> _kredse = new Dictionary<string, Kreds>();

        #endregion

        #region Constructor
        public BadetidsPeriode(string type, DayOfWeek ugedag, DateTime startTidspunkt, DateTime slutTidspunkt, Dictionary<string, Kreds> kredse)
        {

            _type = type;
            _ugedag = ugedag;
            _startTidspunkt = startTidspunkt;
            _slutTidspunkt = slutTidspunkt;
            _kredse = kredse;
        }
        #endregion
        #region Properties
        public string Type
        {
            get { return _type; }
            set 
            {
                int d = _type.Length;
                if (d >= 4)
                {
                    _type = value;
                }
                else
                {
                    Console.WriteLine("Type must be more than 4 characters");
                }
            }
        }
        public DayOfWeek UgeDag
        {
            get { return _ugedag; }
            set { _ugedag = value; }
        }
        public DateTime StartTidspunkt
        {
            get { return _startTidspunkt; }
            set
            {
                if (_startTidspunkt > _slutTidspunkt)
                {
                    _startTidspunkt = value;
                }
                else
                {
                    Console.WriteLine("Start er senere end slut");
                }
            }
        }
            
        public DateTime SlutTidspunkt
        {
            get { return _slutTidspunkt; }
            set { _slutTidspunkt = value; }
        }
        #endregion
        #region methods
        public override string ToString()
        {
            string message = $"Type: {Type} - Ugedag: {UgeDag} - Start: {StartTidspunkt} - Slut: {SlutTidspunkt}";
            foreach (ValueType KeyValue in _kredse)
            {
                _output += KeyValue;
            }
            return message + "                        " + _output;
        }
        public void AdderKreds(Kreds kreds)
        {
            _kredse.Add(kreds.Id, kreds);
        }
        public void SletterKreds(string id)
        {
            _kredse.Remove(id);
        }
        #endregion
    }
}
