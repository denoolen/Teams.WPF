using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Teams.Client.MVVM.Model;

namespace Teams.Client.MVVM.ViewModel
{
		public class MainViewModel : INotifyPropertyChanged
        {
            private ContactModel selectedPhone;

            public ObservableCollection<ContactModel> Phones { get; set; }
            public ContactModel SelectedPhone
            {
                get { return selectedPhone; }
                set
                {
                    selectedPhone = value;
                    OnPropertyChanged("SelectedPhone");
                }
            }

            public MainViewModel()
            {
                Phones = new ObservableCollection<ContactModel>
            {
                new ContactModel { Contactname= "Illay",
                    Statusmessage="NewMessage" },
                new ContactModel {Contactname="Hanna",
                    Statusmessage="hello . .. . . ." },
                new ContactModel {Contactname="Elli",
                    Statusmessage="Hi my dear"},
                new ContactModel {Contactname="Max",
                    Statusmessage="qq ....... awdawdw" }
            };
            }

            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName] string prop = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }


    }
    
