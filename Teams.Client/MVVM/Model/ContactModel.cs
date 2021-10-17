using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teams.Client.MVVM.Model
{
	class ContactModel
	{
		public string UserName { get; set; }
		public string ImageSource { get; set; }
		public ObservableCollection<MessageModel> Messages { get; set; }
		public string LastMessage => Messages.Last().Message;
	}
}
