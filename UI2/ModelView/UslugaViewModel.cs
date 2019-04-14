using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI2.ModelView;
using System.Threading.Tasks;
using UI2.Model;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace UI2.ModelView
{
    public class UslugaViewModel:BindableBase
    {
        Entities2 entities = new Entities2();

        private ICommand addUsluga;
        private ICommand deleteUsluga;
        private ICommand updateUsluga;
        private ICommand saveUpdateUsluga;
        private ICommand dodelaPopravki;

        public ObservableCollection<Popravka> uslugaList = new ObservableCollection<Popravka>();
        
        //public UslugaViewModel()
        //{


        //    foreach (Popravka m in entities.Popravkas)
        //    {
        //        uslugaList.Add(m);

        //    }
        //}
        public ICommand AddUslugaCommand
        {
            get
            {
                if (addUsluga == null)
                {
                    addUsluga = new RelayCommand(_ => AddUsluga());
                }
                return addUsluga;
            }
        }

        public ICommand DeleteUslugaCommand
        {
            get
            {
                if (deleteUsluga == null)
                {
                    deleteUsluga = new RelayCommand(_ => DeleteUsluga());
                }
                return deleteUsluga;
            }
        }

        public ICommand UpdateUslugaCommand
        {
            get
            {
                if (updateUsluga == null)
                {
                    updateUsluga = new RelayCommand(_ => UpdateUsluga());
                }
                return updateUsluga;
            }
        }

        public ICommand SaveUpdateUslugaCommand
        {
            get
            {
               
                if (saveUpdateUsluga == null)
                {
                    
                    saveUpdateUsluga = new RelayCommand(_ => SaveUpdateUsluga());
                }
                return saveUpdateUsluga;
            }
        }

        public ICommand DodelaPopravkiCommand
        {
            get
            {
                if (dodelaPopravki == null)
                {
                    dodelaPopravki = new RelayCommand(_ => DodelaPopravki());
                }
                return dodelaPopravki;
            }
        }


        private DateTime selectedDate;
        public DateTime SelectedDate
        {
            
            get { return selectedDate; }
            set
            {
                selectedDate = value;
                OnPropertyChanged("SelectedDate");
            }
        }

        private Popravka selectedItem;
        public Popravka SelectedItem
        {

            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }


        private string garaza;

        public string Garaza
        {
            get { return garaza; }
            set
            {
                garaza = value;
                OnPropertyChanged("Garaza");

            }
        }


        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set
            {
                naziv = value;
                OnPropertyChanged("Naziv");

            }
        }

        public ObservableCollection<Popravka> UslugaList
        {
            get { return uslugaList; }
            set
            {
                uslugaList = value;
            }
        }


        private void AddUsluga()
        {
            Random random = new Random();
            Popravka popravka = new Popravka();
            popravka.Usluga = new Usluga();

            popravka.Usluga.Vrsta = Naziv;
            popravka.Usluga.Vreme = SelectedDate;
            popravka.Garaza = Garaza;
            popravka.Usluga.Sifra_usluge = random.Next(0, 100);

            entities.Popravkas.Add(popravka);
            entities.SaveChanges();
            uslugaList.Add(popravka);

            Naziv = string.Empty;
            Garaza = string.Empty;

        }


     

        private void DeleteUsluga()
        {

            Popravka nadjen = new Popravka();
            foreach (Popravka m in UslugaList)
            {
                if (UslugaList.Contains(SelectedItem))
                {
                    nadjen = SelectedItem;
                }
            }

            foreach (Popravka m in entities.Popravkas)
            {
                if (m.Usluga.Sifra_usluge == SelectedItem.Usluga.Sifra_usluge)
                {
                    nadjen = m;
                }

            }


            uslugaList.Remove(nadjen);
            entities.Uslugas.Remove(nadjen.Usluga);
            entities.Popravkas.Remove(nadjen);
            entities.SaveChanges();
        }

        private void UpdateUsluga()
        {
            if (SelectedItem != null)
            {
                Naziv = SelectedItem.Usluga.Vrsta;
                Garaza = SelectedItem.Garaza;
                SelectedDate = SelectedItem.Usluga.Vreme;
            }
        }


        private void SaveUpdateUsluga()
        {
            Popravka nadjen = new Popravka();

            foreach (Popravka m in entities.Popravkas)
            {
                if (m.Usluga.Sifra_usluge == SelectedItem.Usluga.Sifra_usluge)
                {
                    nadjen = m;
                }

            }

            Random random = new Random();

            Popravka popravka = new Popravka();

            popravka.Usluga = new Model.Usluga();

            if (Naziv != string.Empty)
                popravka.Usluga.Vrsta = Naziv;

            if (Garaza != string.Empty)
                popravka.Garaza = Garaza;



            popravka.Usluga.Sifra_usluge = SelectedItem.Usluga.Sifra_usluge;
            popravka.Usluga.Vreme = SelectedDate;


            uslugaList.Remove(SelectedItem);
            entities.Uslugas.Remove(nadjen.Usluga);
            entities.Popravkas.Remove(nadjen);

            uslugaList.Add(popravka);
            entities.Popravkas.Add(popravka);
            entities.SaveChanges();

        }

        private void DodelaPopravki()
        {

            View.DodelaPopravkiView dpp = new View.DodelaPopravkiView();
            dpp.ShowDialog();

        }
    }
}
