using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UI2.Model;

namespace UI2.ModelView
{
    public class KvarViewModel:BindableBase
    {
        Entities2 entities = new Entities2();

        private ICommand addKvar;
        private ICommand deleteKvar;
        private ICommand updateKvar;
        private ICommand saveUpdateKvar;

        public ObservableCollection<Kvar> kvarList = new ObservableCollection<Kvar>();

       
        /*public KvarViewModel()
        {
            foreach (Kvar a in entities.Kvars)
            {
                kvarList.Add(a);
            }

        }*/
        public ICommand AddKvarCommand
        {
            get
            {
                if (addKvar == null)
                {
                    addKvar = new RelayCommand(_ => AddKvar());
                }
                return addKvar;
            }
        }

        public ICommand DeleteKvarCommand
        {
            get
            {
                if (deleteKvar == null)
                {
                    deleteKvar = new RelayCommand(_ => DeleteKvar());
                }
                return deleteKvar;
            }
        }

        public ICommand UpdateKvarCommand
        {
            get
            {
                if (updateKvar == null)
                {
                    updateKvar = new RelayCommand(_ => UpdateKvar());
                }
                return updateKvar;
            }
        }

        public ICommand SaveUpdateKvarCommand
        {
            get
            {
                if (saveUpdateKvar == null)
                {
                    saveUpdateKvar = new RelayCommand(_ => SaveUpdateKvar());
                }
                return saveUpdateKvar;
            }
        }


        public ObservableCollection<Kvar> KvarList
        {

            get { return kvarList; }
            set { kvarList = value; }

        }

        private string tip;

        public string Tip
        {
            get { return tip; }
            set
            {
                tip = value;
                OnPropertyChanged("Tip");
            }
        }
     
        private void AddKvar()
        {

            Kvar kvar = new Kvar();
            Random rand = new Random();
            kvar.Tip_kvara = Tip;

            kvar.Sifra_kvara = rand.Next(0, 100);

            kvarList.Add(kvar);
            entities.Kvars.Add(kvar);
            entities.SaveChanges();


            Tip = string.Empty;


        }


        private Kvar selectedItem;

        public Kvar SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
            }
        }

        private void DeleteKvar()
        {

            Kvar nadjen = new Kvar();
            foreach (Kvar m in entities.Kvars)
            {
                if (kvarList.Contains(SelectedItem))
                {
                    nadjen = SelectedItem;
                }
            }

            foreach (Kvar m in entities.Kvars)
            {
                if (m.Sifra_kvara == SelectedItem.Sifra_kvara)
                {
                    nadjen = m;
                }

            }

            kvarList.Remove(nadjen);
            entities.Kvars.Remove(nadjen);
            entities.SaveChanges();
        }

        private void UpdateKvar()
        {
            if (SelectedItem != null)
            {
                Tip = SelectedItem.Tip_kvara;

            }
        }


        private void SaveUpdateKvar()
        {
            Kvar nadjen = new Kvar();

            foreach (Kvar m in entities.Kvars)
            {
                if (m.Sifra_kvara == SelectedItem.Sifra_kvara)
                {
                    nadjen = m;
                }

            }

            Kvar kvar = new Kvar();

            if (Tip != string.Empty)
                kvar.Tip_kvara = Tip;


            kvar.Sifra_kvara = SelectedItem.Sifra_kvara;


            kvarList.Remove(SelectedItem);
            entities.Kvars.Remove(nadjen);

            kvarList.Add(kvar);
            entities.Kvars.Add(kvar);
            entities.SaveChanges();

        }
    }
}
