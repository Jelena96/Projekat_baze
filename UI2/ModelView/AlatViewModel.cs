using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UI2.Model;
using UI2.View;

namespace UI2.ModelView
{
    public class AlatViewModel:BindableBase
    {
        Entities2 entities = new Entities2();

        private ICommand addAlat;
        private ICommand deleteAlat;
        private ICommand updateAlat;
        private ICommand saveUpdateAlat;

        public ObservableCollection<Alat> alatList = new ObservableCollection<Alat>();

        //public AlatViewModel()
        //{
        //    foreach (Alat a in entities.Alats)
        //    {
        //        alatList.Add(a);
        //    }

        //}
        public ICommand AddAlatCommand
        {
            get
            {
                if (addAlat == null)
                {
                    addAlat = new RelayCommand(_ => AddAlat());
                }
                return addAlat;
            }
        }

        public ICommand DeleteAlatCommand
        {
            get
            {
                if (deleteAlat == null)
                {
                    deleteAlat = new RelayCommand(_ => DeleteAlat());
                }
                return deleteAlat;
            }
        }

        public ICommand UpdateAlatCommand
        {
            get
            {
                if (updateAlat == null)
                {
                    updateAlat = new RelayCommand(_ => UpdateAlat());
                }
                return updateAlat;
            }
        }

        public ICommand SaveUpdateAlatCommand
        {
            get
            {
                if (saveUpdateAlat == null)
                {
                    saveUpdateAlat = new RelayCommand(_ => SaveUpdateAlat());
                }
                return saveUpdateAlat;
            }
        }

        private ICommand dodeliAlatCommand;
        public ICommand DodeliAlatCommand
        {
            get
            {
                if (dodeliAlatCommand == null)
                {
                    dodeliAlatCommand = new RelayCommand(_ => DodeliAlat());
                }
                return dodeliAlatCommand;
            }
        }

        private void DodeliAlat()
        {
            KoristiView koristiView = new KoristiView();
            koristiView.ShowDialog();
        }

        public ObservableCollection<Alat> AlatList {

            get { return alatList; }
            set { alatList = value; }

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

        private void AddAlat()
        {

            Alat alat = new Alat();
            Random rand = new Random();
            alat.Naziv_alata = Naziv;

            alat.Sifra_alata = rand.Next(0, 100);
            entities.Alats.Add(alat);
            entities.SaveChanges();

            alatList.Add(alat);
            Naziv = string.Empty;
     

        }

        private ICommand pronadjiUcestanostAlata;

        public ICommand PronadjiUcestanostAlata
        {
            get
            {
                if (pronadjiUcestanostAlata == null)
                {
                    pronadjiUcestanostAlata = new RelayCommand(_ => PronadjiUcestanost());
                }
                return pronadjiUcestanostAlata;
            }

        }

        private int br;

        public int Br {

            get { return br; }
            set { br = value; OnPropertyChanged("Br"); }
        }

        private void PronadjiUcestanost()
        {

            Br = entities.Database.SqlQuery<int>($"SELECT [dbo].[Funkcija]()").FirstOrDefault();
         
        }


        private Alat selectedItem;

        public Alat SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
            }
        }

        private void DeleteAlat()
        {

            Alat nadjen = new Alat();
            foreach (Alat m in entities.Alats)
            {
                if (AlatList.Contains(SelectedItem))
                {
                    nadjen = SelectedItem;
                }
            }

            foreach (Alat m in entities.Alats)
            {
                if (m.Sifra_alata == SelectedItem.Sifra_alata)
                {
                    nadjen = m;
                }

            }

            AlatList.Remove(nadjen);
            entities.Alats.Remove(nadjen);
            entities.SaveChanges();
        }

        private void UpdateAlat()
        {
            if (SelectedItem != null)
            {
                Naziv = SelectedItem.Naziv_alata;
           
            }
        }


        private void SaveUpdateAlat()
        {
            Alat nadjen = new Alat();

            foreach (Alat m in entities.Alats)
            {
                if (m.Sifra_alata == SelectedItem.Sifra_alata)
                {
                    nadjen = m;
                }
                
            }

            Alat alat = new Alat();

            if (Naziv != string.Empty)
                alat.Naziv_alata = Naziv;


            alat.Sifra_alata = SelectedItem.Sifra_alata;
          

            alatList.Remove(SelectedItem);
            entities.Alats.Remove(nadjen);

            alatList.Add(alat);
            entities.Alats.Add(alat);
            entities.SaveChanges();

        }
    }
}
