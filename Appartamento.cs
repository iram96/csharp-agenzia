namespace csharp_agenzia
{
    public class Appartamento : Immobile
    {
        public int Vani { get; set; }
        public int Bagni { get; set; }

        public Appartamento(string sCodiceImmo, string sIndirizzo, string iCAP, string sCitta, int iSuperficie, int iVani, int iBagni) : base(sCodiceImmo, sIndirizzo, iCAP, sCitta, iSuperficie)
        {
            this.Vani = iVani;
            this.Bagni = iBagni;
        }

        public override string ToString()
        {
            return string.Format("Appartamento: \n{0}", Write());
        }

        protected override string Write()
        {
            return string.Format("{0}\nVani : {1} \nBagni : {2}", base.Write(), this.Vani, this.Bagni);
        }
        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.Vani.ToString().Contains(key)) return true;
            else if (this.Bagni.ToString().Contains(key)) return true;
            else return false;
        }


    }
}
