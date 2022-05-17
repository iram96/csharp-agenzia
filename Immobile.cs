
/* 
 Esercizio 2: Agenzia immobiliare

Si vuole progettare un’applicazione in grado di gestire un’agenzia 
immobiliare. 

Gli immobili sono caratterizzati da:
- un codice alfanumerico, 
- indirizzo, 
- cap, 
- città 
- una superficie espressa in mq attraverso un numero intero. 


L’agenzia gestisce diverse tipologie di immobili: 
- Box, 
- Appartamenti 
- Ville.

Per i box è riportato il numero di posti auto. 
Per gli appartamenti è 
riportato in numero di vani e il numero di bagni.

Per le ville è previsto, 
in aggiunta rispetto all’appartamento, la dimensione in mq di giardino.

Ridefinire per ciascuna delle tre classi il metodo ToString in modo da fornire 
una descrizione completa dell'immobile. StampaSchedaImmobile

Provare a pensare ad una funzione di ricerca.
*/

namespace csharp_agenzia
{
    public class Immobile

    {

        public string CodiceImmo { get; set; }
        // public string CodiceImmobiliare { get; set; }
        public string Indirizzo { get; set; }
        public string CAP { get; set; }
        public string Citta { get; set; }
        public int Superficie { get; set; }

        public Immobile(string sCodiceImmo, string sIndirizzo, string iCAP, string sCitta, int iSuperficie)
        {
            this.CodiceImmo = sCodiceImmo;
            this.Indirizzo = sIndirizzo;
            this.CAP = iCAP;
            this.Citta = sCitta;
            this.Superficie = iSuperficie;

        }


        protected virtual string Write()
        {
            return string.Format("Codice immobiliare : {0} \n" +
                "Indirizzo : {1} \n" +
                "CAP : {2} \n" +
                "Città : {3} \n" +
                "Superficie : {4} mq \n", CodiceImmo, Indirizzo, CAP, Citta, Superficie);
        }

        /*public virtual bool Contains(string key)
        {
            if (this.CodiceImmo.Contains(key)) return true;
            else if (this.Indirizzo.Contains(key)) return true;
            else if (this.CAP.Contains(key)) return true;
            else if (this.Citta.Contains(key)) return true;
            else if (this.)
        }*/

        public virtual bool Contains(string key)
        {

            if (this.CodiceImmo.Contains(key)) return true;
            else if (this.Indirizzo.Contains(key)) return true;
            else if (this.CAP.Contains(key)) return true;
            else if (this.Citta.Contains(key)) return true;
            else if (this.Superficie.ToString().Contains(key)) return true;
            else return false;
        }

    }






}