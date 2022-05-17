namespace csharp_agenzia
{
    internal class Agenzia
    {
        private string nome;
        public string Nome { get => nome; set => nome = value; }
        public List<Immobile> listaImmobili { get; set; }




        public Agenzia(string nome)
        {
            this.Nome = nome;
            listaImmobili = new List<Immobile>();

        }


        public void AddImmobile(Immobile i)
        {
            listaImmobili.Add(i);
        }



        public void CercaImmobile(string codice)
        {
            foreach (Immobile item in listaImmobili)
            {
                if (item.CodiceImmo == codice)
                {
                    Console.WriteLine("l'immobile e presente nel DB dell'agenzia");
                    return;
                }
                else
                {
                    Console.WriteLine("L'immobile cercato non e disponibile");
                    return;
                }
            }
        }



        public List<Immobile> SearchImmobili(string key)
        {
            return this.listaImmobili.FindAll(i => i.Contains(key));
        }

        public void AddListaImmobili(List<Immobile> i)
        {
            foreach (Immobile im in i)
                AddImmobile(im);
        }
    }
}
