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
        //Som administrator vil jeg gerne have at der skal være en pris på for hver kreds for at besøgene kan se hvor meget det koster.
        int _pris;
        #endregion

        #region Constructor
        public Kreds(string id, string navn, string adresse, int antalDeltagere, int pris)
        {
            _id = id;
            _navn = navn;
            _adresse = adresse;
            _antalDeltagere = antalDeltagere;
            _pris = pris;
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
                if(_antalDeltagere == 0)
                {
                    throw new ArgumentException("Antal deltagere skal være større end 0");
                }
                _antalDeltagere = value;
            }
        }
        public int Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }
        #endregion

        #region methods
        public override string ToString()
        {
            string message = $"Kreds id: {Id} - Kreds navn: {Navn} - Kreds adresse: {Adresse} - Antal deltagere: {AntalDeltagere} - Pris pr. kvartal: {Pris}";
            return message;
        }
        #endregion

    }




}
