using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    public class Kreds
    {
        #region instance fields
        string _id;
        string _navn;
        string _adresse;
        int _antalDeltagere;
        #endregion

        #region Constructor
        public Kreds(string id, string navn, string adresse, int antalDeltagere)
        {
            _id = id;
            _navn = navn;
            _adresse = adresse;
            AntalDeltagere = antalDeltagere;
        }
        #endregion

        #region Properties
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
        public int AntalDeltagere
        {
            get { return _antalDeltagere; }
            set 
            { 
                if(_antalDeltagere > 0)
                {
                    _antalDeltagere = value;
                }
                else
                {
                    throw new ArgumentException("Antal deltagere skal være større end 0");
                }
            }
        }
        #endregion

        #region methods
        public override string ToString()
        {
            string message = $"Kreds id: {Id} - Kreds navn: {Navn} - Kreds adresse: {Adresse} - Antal deltagere: {AntalDeltagere}";
            return message;
        }
        #endregion

    }




}
