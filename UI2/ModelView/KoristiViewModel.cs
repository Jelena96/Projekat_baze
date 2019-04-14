using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UI2.Model;

namespace UI2.ModelView
{
    public class KoristiViewModel:BindableBase
    {
        BindingList<KeyValuePair<Popravlja, Alat>> majstorKvarList = new BindingList<System.Collections.Generic.KeyValuePair<Popravlja, Alat>>();
        Entities2 entities = new Entities2();
        List<int> radnikList = new List<int>();
        List<int> kvarList = new List<int>();
        List<int> popravljanjaList = new List<int>();

        List<int> alatList = new List<int>();

        //public KoristiViewModel()
        //{

        //    foreach (Popravlja k in entities.Popravljas)
        //    {
        //        kvarList.Add(k.Kvar_Sifra_kvara);
        //        radnikList.Add(k.Majstor_Sifra_radnika);
        //    }

        //    foreach (Popravlja k in entities.Popravljas)
        //    {
        //    }

        //    foreach (Alat m in entities.Alats)
        //    {
        //        alatList.Add(m.Sifra_alata);
        //    }
        //}
        public BindingList<KeyValuePair<Popravlja, Alat>> MajstorKvarList
        {
            get { return majstorKvarList; }
            set { majstorKvarList = value; }

        }

        public List<int> KvarList
        {
            get { return kvarList; }
            set { kvarList = value; }

        }

        public List<int> RadnikList
        {
            get { return radnikList; }
            set { radnikList = value; }

        }

        public List<int> AlatList
        {
            get { return alatList; }
            set { alatList = value; }

        }

        private int selectedKvar;

        public int SelectedKvar
        {
            get { return selectedKvar; }
            set
            {
                selectedKvar = value;
            }
        }

    

        private int selectedAlat;

        public int SelectedAlat
        {
            get { return selectedAlat; }
            set
            {
                selectedAlat = value;
            }
        }

        private ICommand add;

        public ICommand AddCommand
        {
            get
            {
                if (add == null)
                {
                    add = new RelayCommand(_ => Add());
                }
                return add;
            }
        }

        private void Add()
        {
            Alat alat = new Alat();

            foreach (Alat a in entities.Alats)
            {

                if (a.Sifra_alata == SelectedAlat)
                {
                    alat = a;
                }

            }


            Popravlja popravlja = new Popravlja();


            foreach (Popravlja p in entities.Popravljas)
            {
                if (p.Kvar_Sifra_kvara == SelectedKvar)
                {
                  
                        popravlja = p;
                    
                }

            }
            
            string ime = popravlja.Majstor.Radnik.Ime;
            popravlja.Alats.Add(alat);
            string kvar = popravlja.Kvar.Tip_kvara;
            (entities.Popravljas.Where(a => a.Kvar_Sifra_kvara == SelectedKvar).FirstOrDefault().Alats).Add(entities.Alats.Where(m => m.Sifra_alata == SelectedAlat).FirstOrDefault());


            entities.SaveChanges();
            majstorKvarList.Add(new KeyValuePair<Popravlja, Alat>(popravlja, alat));
        }

    }
}
