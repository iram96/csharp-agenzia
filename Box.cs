namespace csharp_agenzia
{
    public class Box : Immobile
    {
        public int PostiAuto { get; set; }

        public Box(string sCodiceImmo, string sIndirizzo, string iCAP, string sCitta, int iSuperficie, int iPostiAuto) : base(sCodiceImmo, sIndirizzo, iCAP, sCitta, iSuperficie)
        {
            this.PostiAuto = iPostiAuto;
        }

        public override string ToString()
        {
            return string.Format("Box: \n{0}", Write());
        }

        protected override string Write()
        {
            return string.Format("{0} \n Posti Auto : {1}", base.Write(), this.PostiAuto);
        }

        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.PostiAuto.ToString().Contains(key)) return true;
            else return false;
        }

        public void StampaSchedaImmobile()
        {

        }

    }
}
