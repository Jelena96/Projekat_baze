using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UI2.Model;

namespace UI2.ModelView
{
    public class RadnikViewModel:BindableBase
    {
         Entities2 entities = new Entities2();
        
        private ICommand addRadnik;
        private ICommand deleteRadnik;
        private ICommand updateRadnik;
        private ICommand saveUpdateRadnik;

        public ObservableCollection<Majstor> radnikList = new ObservableCollection<Majstor>();

       /* public RadnikViewModel()
        {
            foreach (Majstor m in entities.Majstors)
            {
                radnikList.Add(m);
            }

        }*/
        public ICommand AddRadnikCommand
        {
            get
            {
                if (addRadnik == null)
                {
                    addRadnik = new RelayCommand(_ => AddRadnik());
                }
                return addRadnik;
            }
        }

        public ICommand DeleteRadnikCommand
        {
            get
            {
                if (deleteRadnik == null)
                {
                    deleteRadnik = new RelayCommand(_ => DeleteRadnik());
                }
                return deleteRadnik;
            }
        }

        public ICommand UpdateRadnikCommand
        {
            get
            {
                if (updateRadnik == null)
                {
                    updateRadnik = new RelayCommand(_ => UpdateRadnik());
                }
                return updateRadnik;
            }
        }

        public ICommand SaveUpdateRadnikCommand
        {
            get
            {
                if (saveUpdateRadnik == null)
                {
                    saveUpdateRadnik = new RelayCommand(_ => SaveUpdateRadnik());
                }
                return saveUpdateRadnik;
            }
        }

        
        private string ime;
        public string Ime
        {
            get { return ime; }
            set
            {
                ime = value;
                OnPropertyChanged("Ime");
            }
        }

        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set
            {
                prezime = value;
                OnPropertyChanged("Prezime");
            }
        }

        private string mbr;

        public string MBR
        {
            get { return mbr; }
            set
            {
                mbr = value;
                OnPropertyChanged("MBR");

            }
        }

        private string specijalnost;

        public string Specijalnost
        {
            get { return specijalnost; }
            set
            {
                specijalnost = value;
                OnPropertyChanged("Specijalnost");

            }
        }

        public ObservableCollection<Majstor> RadnikList
        {
            get { return radnikList; }
            set
            {
                radnikList = value;
            }
        }


        private void AddRadnik()
        {
            Random random = new Random();

            Majstor radnik = new Majstor();
            
            radnik.Radnik = new Radnik();
            radnik.Radnik.Ime = Ime;
            radnik.Radnik.Prezime = Prezime;
            radnik.Radnik.MBR = MBR;
            radnik.Radnik.Sifra_radnika = random.Next(0, 100);

            string[] speci = Specijalnost.Split(' ');
            radnik.Specijalnost = speci[1];

            radnik.Radnik.Majstor = "";    

            entities.Majstors.Add(radnik);
            entities.SaveChanges();

            foreach (Majstor m in entities.Majstors)
            {
                RadnikList.Add(m);

            }

            Ime = string.Empty;
            Prezime = string.Empty;
            MBR = string.Empty;
            Specijalnost = string.Empty;

        }


        private Majstor selectedItem;

        public Majstor SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
            }
        }

        private void DeleteRadnik() {

            Majstor nadjen = new Majstor();
            foreach (Majstor m in RadnikList)
            {
                if (RadnikList.Contains(SelectedItem))
                {
                    nadjen = SelectedItem;
                }
            }

            foreach (Majstor m in entities.Majstors)
            {
                if (m.Radnik.Sifra_radnika == SelectedItem.Radnik.Sifra_radnika)
                {
                    nadjen = m;
                }

            }


            RadnikList.Remove(nadjen);
            entities.Radniks.Remove(nadjen.Radnik);
            entities.Majstors.Remove(nadjen);
            entities.SaveChanges();
        }

        private void UpdateRadnik()
        {
            if (SelectedItem != null)
            {
                Ime = SelectedItem.Radnik.Ime;
                Prezime = SelectedItem.Radnik.Prezime;
                MBR = SelectedItem.Radnik.MBR;
                Specijalnost = SelectedItem.Specijalnost;
                }
            }


        private void SaveUpdateRadnik()
        {
            Majstor nadjen = new Majstor();

            foreach (Majstor m in entities.Majstors)
            {
                if (m.Radnik.Sifra_radnika == SelectedItem.Radnik.Sifra_radnika)
                {
                    nadjen = m;
                }
              
            }

                Random random = new Random();

                Majstor radnik = new Majstor();

                radnik.Radnik = new Radnik();

                if (Ime != string.Empty)
                    radnik.Radnik.Ime = Ime;

                if (Prezime != string.Empty)
                    radnik.Radnik.Prezime = Prezime;

                if (MBR != string.Empty)
                    radnik.Radnik.MBR = MBR;

                radnik.Radnik.Sifra_radnika = SelectedItem.Radnik.Sifra_radnika;
                radnik.Radnik.Majstor = "";

                if (Specijalnost != string.Empty)
                {
                    string[] speci = Specijalnost.Split(' ');
                    radnik.Specijalnost = speci[1];
                }

                RadnikList.Remove(SelectedItem);
                entities.Radniks.Remove(nadjen.Radnik);
                entities.Majstors.Remove(nadjen);
                
                RadnikList.Add(radnik);
                entities.Majstors.Add(radnik);
                entities.SaveChanges();

        }
    }
}
