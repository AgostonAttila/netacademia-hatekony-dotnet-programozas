using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NyomtatásWPF
{

   // Ehelyett van Thirdparty MVVM komponens

    //Klikk esemény helyett, így ha designba változtatok megmarad  pl label helyett textbox v más

    public class AblakViewModel : INotifyPropertyChanged
    {
        UzletiObjektum o;

        public AblakViewModel()
        {
            o = new UzletiObjektum() { Duma = "eredeti" };
        }

        public UzletiObjektum Uzleti
        {
            get { return o; }
            set
            {
                if (o != value)
                {
                    o = value;
                    RaisePropertyChanged("Uzleti");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        void RaisePropertyChanged(string propertyNeve)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyNeve));
        }


        void MasikUzleti()
        {
            Uzleti = new UzletiObjektum() { Duma = DateTime.Now.ToString() };
        }

        ICommand _csereCommand;
        public ICommand CsereCommand
        {
            get
            {
                if (_csereCommand == null)
                    _csereCommand = new SajaTparancs(this);

                return _csereCommand;
            }
        }


        class SajaTparancs : ICommand
        {
            AblakViewModel vm;
            public SajaTparancs(AblakViewModel vm)
            {
                this.vm = vm;
            }


            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
                throw new NotImplementedException();
            }
        }

    }
}
