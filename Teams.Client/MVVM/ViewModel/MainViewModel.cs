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
            private ContactModel selectedUser;

            public ObservableCollection<ContactModel> Users { get; set; }
            public ContactModel UserSelect
            {
                get { return selectedUser; }
                set
                {
                    selectedUser = value;
                    OnPropertyChanged("UserSelect");
                }
            }

            public MainViewModel()
            {
                Users = new ObservableCollection<ContactModel>
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
    
