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
    public class DodelaPopravkiViewModel:BindableBase
    {
        BindingList<KeyValuePair<Popravka, Majstor>> majstorPopravkaList = new BindingList<System.Collections.Generic.KeyValuePair<Popravka, Majstor>>();
        Entities2 entities = new Entities2();
        List<string> radnikList = new List<string>();
        List<int> popravkaList = new List<int>();


        //public DodelaPopravkiViewModel()
        //{

        //    foreach (Popravka k in entities.Popravkas)
        //    {
        //        popravkaList.Add(k.Sifra_usluge);
        //    }

        //    foreach (Majstor m in entities.Majstors)
        //    {
        //        radnikList.Add(m.Radnik.Ime);
        //    }

        //    Majstor maj = new Majstor();
        //    foreach (Popravka p in entities.Popravkas)
        //    {
        //        maj = p.Majstors.FirstOrDefault();

        //        majstorPopravkaList.Add(new KeyValuePair<Popravka, Majstor>(p, maj));

        //    }


        //}
        public BindingList<KeyValuePair<Popravka, Majstor>> MajstorPopravkaList
        {
            get { return majstorPopravkaList; }
            set { majstorPopravkaList = value; }

        }

        public List<int> PopravkaList
        {
            get { return popravkaList; }
            set { popravkaList = value; }

        }

        public List<string> RadnikList
        {
            get { return radnikList; }
            set { radnikList = value; }

        }

      
        

        private int selectedPopravka;

        public int SelectedPopravka
        {
            get { return selectedPopravka; }
            set
            {
            selectedPopravka = value;
            }
        }



        private string selectedRadnik;

        public string SelectedRadnik
        {
            get { return selectedRadnik; }
            set
            {
                selectedRadnik = value;
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
            Popravka popravka = null;
            
            foreach (Popravka a in entities.Popravkas)
            {

                if (a.Usluga.Sifra_usluge == SelectedPopravka)
                {
                    popravka = a;
                }
               

            }


            Majstor majstor = new Majstor();


            foreach (Majstor p in entities.Majstors)
            {
                if (p.Radnik.Ime == SelectedRadnik)
                {
                    popravka.Majstors.Add(p);
                    majstor = p;
                }

            }

            string ime = majstor.Radnik.Ime;
            (entities.Popravkas.Where(a => a.Usluga.Sifra_usluge == SelectedPopravka).FirstOrDefault().Majstors).Add(entities.Majstors.Where(m=> m.Radnik.Ime == SelectedRadnik).FirstOrDefault());
            entities.SaveChanges();
           majstorPopravkaList.Add(new KeyValuePair<Popravka, Majstor>(popravka, majstor));
            
        }
    }
}
