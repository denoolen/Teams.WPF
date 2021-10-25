using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Teams.Client.MVVM.Model
{
	public class ContactModel : INotifyPropertyChanged
	{
	

	        private string ContactName;
            private string StatusMessage;
            private string Message;


        public string Contactname
            {
                get { return ContactName; }
                set
                {
                    ContactName = value;
                    OnPropertyChanged("Contactname");
                }
            }
            public string Statusmessage
            {
                get { return StatusMessage; }
                set
                {
                    StatusMessage = value;
                    OnPropertyChanged("Statusmessage");
                }
            }

        public string MSG
        {
            get { return Message; }
            set
            {
                Message = value;
                OnPropertyChanged("MSG");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName] string prop = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

    }

