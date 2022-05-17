namespace csharp_agenzia
{
    public class Villa : Appartamento
    {
        public int SuperficieGiardino { get; set; }

        public Villa(string sCodiceImmo, string sIndirizzo, string iCAP, string sCitta, int iSuperficie, int iVani, int iBagni, int iSupGiardino) : base(sCodiceImmo, sIndirizzo, iCAP, sCitta, iSuperficie, iVani, iBagni)
        {
            this.SuperficieGiardino = iSuperficie;
        }

        public override string ToString()
        {
            return string.Format("Villa: \n{0}", Write());
        }

        protected override string Write()
        {
            return string.Format("{0}\nSuperficie Giardino : {1}", base.Write(), this.SuperficieGiardino);
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
