using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UI2.Model;

namespace UI2.ModelView
{
    public class PopravljaViewModel:BindableBase
    {
        Entities2 entities = new Entities2();
        List<int> kvarList = new List<int>();
        List<int> majstorList = new List<int>();
        BindingList<KeyValuePair<Majstor,Kvar>> majstorKvarList = new BindingList<System.Collections.Generic.KeyValuePair<Majstor, Kvar>>();
        List<KeyValuePair<Majstor, Kvar>> majstorKvarList2 = new List<System.Collections.Generic.KeyValuePair<Majstor, Kvar>>();

        public List<int> KvarList {

            get { return kvarList; }
            set { kvarList = value;
                OnPropertyChanged("KvarList");
            }

        }


        public List<int> MajstorList
        {

            get { return majstorList; }
            set
            {
                majstorList = value;
                OnPropertyChanged("MajstorList");
            }
        }

        public BindingList<KeyValuePair<Majstor, Kvar>> MajstorKvarList
        {
            get { return majstorKvarList; }
            set { majstorKvarList = value;
            }

        }

        public List<KeyValuePair<Majstor, Kvar>> MajstorKvarList2
        {
            get { return majstorKvarList2; }
            set
            {
                majstorKvarList2 = value;
                OnPropertyChanged("MajstorKvarList2");
            }

        }
      /*  public PopravljaViewModel()
        {
            foreach (Kvar k in entities.Kvars)
            {
                kvarList.Add(k.Sifra_kvara);
            }


            foreach (Majstor m in entities.Majstors)
            {
                majstorList.Add(m.Radnik.Sifra_radnika);
            }
        }
        */

        private int selectedKvar;

        public int SelectedKvar
        {
            get { return selectedKvar; }
            set
            {
                selectedKvar = value;
            }
        }

        private int selectedMajstor;

        public int SelectedMajstor
        {
            get { return selectedMajstor; }
            set
            {
                selectedMajstor = value;
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

        private ICommand show;
        public ICommand ShowCommand
        {
            get
            {
                if (show == null)
                {
                    show = new RelayCommand(_ => Show());
                }
                return show;
            }
        }

        private void Add()
        {

            Majstor majstor = new Majstor();
            foreach (Majstor m in entities.Majstors)
            {
                if (m.Radnik.Sifra_radnika == SelectedMajstor)
                {
                    majstor = m;
                }
            }

            Kvar kvar = new Kvar();
            foreach (Kvar m in entities.Kvars)
            {
                if (m.Sifra_kvara == SelectedKvar)
                {
                    kvar = m;
                }
            }

            majstorKvarList.Add(new KeyValuePair<Majstor, Kvar>( majstor, kvar));

            Popravlja popravlja = new Popravlja();
            Popravka p = new Popravka();
            
            popravlja.Kvar_Sifra_kvara = SelectedKvar;
            popravlja.Majstor_Sifra_radnika = SelectedMajstor;

            entities.Popravljas.Add(popravlja);
            entities.SaveChanges();

        }

        private void Show()
        {

        }


    }
}
