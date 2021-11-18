﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teams.Client.MVVM.Model
{
	 public class MessageModel : ViewModelBase
    {
        private string ContactName;
        private string StatusMessage;
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
        public string Statusmessage
        {
            get { return StatusMessage; }
            set
            {
                StatusMessage = value;
                OnPropertyChanged("Statusmessage");
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
                OnPropertyChanged("CustomMessage");
            }
        }

    }
}
