using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teams.Client.MVVM.Model
{
	 public class MessageModel : ViewModelBase
    {
        private string _text;
        private string name;
        private string ContactName;
        private string Message;
        private string MessageFromUser;
        private DateTime _startDate = DateTime.Now;
        public bool IsSending { get; set; }
        public DateTime StartDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                OnPropertyChanged("StartDate");
            }
        }
 

        public string Contactname
        {
            get { return ContactName; }
            set
            {
                ContactName = value;
                OnPropertyChanged("Contactname");
            }
        }

        public string UserMessage
        {
            get { return Message; }
            set
            {
                Message = value;
                OnPropertyChanged("UserMessage");
            }
        }
        public string MessagefromUser
        {
            get { return MessageFromUser; }
            set
            {
                MessageFromUser = value;
                OnPropertyChanged("MessagefromUser");
            }
        }
      
        public string UserName
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("UserName");
            }
        }
        
        public string Text
        {
            get { return _text; }
            set { _text = value; 
                OnPropertyChanged(Text);
            }
        }

    }
}
