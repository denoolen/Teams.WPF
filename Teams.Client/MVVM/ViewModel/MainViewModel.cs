using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Teams.Client.Commands;
using Teams.Client.MVVM.Model;

namespace Teams.Client.MVVM.ViewModel
{
	public class MainViewModel : ContactModel
	{
		public ICommand CloseApplicationCommand
		{
			get;
		}
		private void OnCloseApplicationCommandExecuted(object p)
		{
			Application.Current.Shutdown();
		}
		private bool CanCloseApplicationCommandExecuted(object p)
		{
			return true;
		}

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
					Statusmessage="NewMessage" , MSG = " hello my dear friend how are you? "},
				new ContactModel {Contactname="Hanna",
					Statusmessage="hello . .. . . .", MSG = "I have a question when can we meet? " },
				new ContactModel {Contactname="Elli",
					Statusmessage="Hi my dear"},
				new ContactModel {Contactname="Max",
					Statusmessage="qq ....... awdawdw" }
			};
			CloseApplicationCommand = new ActionCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecuted);

		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}

	}


}