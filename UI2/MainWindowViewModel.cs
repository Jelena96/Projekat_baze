using System;
using UI2.ModelView;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI2.Model;
using UI2.View;
using System.Windows.Input;
using System.ComponentModel;

namespace UI2
{
    public class MainWindowViewModel:BindableBase
    {
        private ICommand radnikWindow;
        public ICommand RadnikWindow
        {
            get
            {
                if (radnikWindow == null)
                {
                    radnikWindow = new RelayCommand(_=> AddRadnik());
                }
                return radnikWindow;
            }
        }

      

        public void AddRadnik() {

            RadnikView win2 = new RadnikView();
            win2.ShowDialog(); 

        }

        private ICommand uslugaWindow;

        public ICommand UslugaWindowCommand
        {
            get
            {
                if (uslugaWindow == null)
                {
                    uslugaWindow = new RelayCommand(_ => UslugaWindow());
                }
                return uslugaWindow;
            }
        }



        public void UslugaWindow()
        {
            View.Usluga view = new View.Usluga();
            view.ShowDialog();

        }

        private ICommand alatWindow;

        public ICommand AlatWindowCommand
        {
            get
            {
                if (alatWindow == null)
                {
                    alatWindow = new RelayCommand(_ => AlatWindow());
                }
                return alatWindow;
            }
        }



        public void AlatWindow()
        {

            AlatView win2 = new AlatView();
            win2.ShowDialog();

        }

        private ICommand kvarWindow;

        public ICommand KvarWindowCommand
        {
            get
            {
                if (kvarWindow == null)
                {
                    kvarWindow = new RelayCommand(_ => KvarWindow());
                }
                return kvarWindow;
            }
        }



        public void KvarWindow()
        {

            KvarView win2 = new KvarView();
            win2.ShowDialog();

        }


        private ICommand dodeliPopravkuWindow;
        public ICommand DodeliPopravkuWindowCommand
        {
            get
            {
                if (dodeliPopravkuWindow == null)
                {
                    dodeliPopravkuWindow = new RelayCommand(_ => DodeliPopravkuWindow());
                }
                return dodeliPopravkuWindow;
            }
        }



        public void DodeliPopravkuWindow()
        {

            PopravljaView win2 = new PopravljaView();
            win2.ShowDialog();

        }

    }
}
