using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    public class BadetidsPeriode
    {
        #region Instance
        string _type;
        DayOfWeek _ugedag;
        DateTime _startTidspunkt;
        DateTime _slutTidspunkt;
        string _output;
        Dictionary<string, Kreds> _kredse = new Dictionary<string, Kreds>();
        //Som administrator vil jeg gerne kunne lave en beskrivelse for hver badetidsperiode, så gæster lettere kan se hvad det helt præcist går ud på.
        public string Beskrivelse { get; set; }
        #endregion

        #region Constructor
        public BadetidsPeriode(string type, DayOfWeek ugedag, DateTime startTidspunkt, DateTime slutTidspunkt, Dictionary<string, Kreds> kredse)
        {
            _ugedag = ugedag;
            _startTidspunkt = startTidspunkt;
           _slutTidspunkt = slutTidspunkt;
            _kredse = kredse;
            _type = type;
        }
        #endregion
        #region Properties
        public string Type
        {
            get { return _type; }
            set
            {
                if(_type.Length < 4)
                {
                    throw new ArgumentException();
                }
                _type = value;  
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
                    throw new ArgumentException();
                }
                _startTidspunkt = value;
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
            string message = $"Type: {Type} - Ugedag: {UgeDag} - Start: {StartTidspunkt} - Slut: {SlutTidspunkt} - Beskrivelse: {Beskrivelse}";
            foreach (KeyValuePair<string, Kreds> entry in _kredse)
            {
                _output += entry;
            } 
            return message + "                        " + _output;
        }
        public virtual void AdderKreds(Kreds kreds)
        {
            _kredse.Add(kreds.Id, kreds);
        }
        public virtual void SletterKreds(string id)
        {
            _kredse.Remove(id);
        }
        //User story: Som administrator vil jeg gerne kunne udskrive en liste over alle kredse i dictionary for at jeg kan få et bedre overblik over kredsene kun.
        public void ReadKreds()
        {
            foreach(KeyValuePair<string, Kreds> entry in _kredse)
            {
                Console.WriteLine(entry.Value);
            }
        }
        #endregion
    }
}
