using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Teams.Client.Commands;
using Teams.Client.MVVM.Model;

namespace Teams.Client.MVVM.ViewModel
{
	public class MainViewModel : MessageModel
	{

		public ICommand SendCommand { get; set; }

		public ObservableCollection<ViewModelBase> Users { get; set; }


		public MainViewModel()
		{
			Users = new ObservableCollection<ViewModelBase>
			{
				new MessageModel  {
					IsSending = true,
					Contactname= "Iam",
					Statusmessage= " from " ,
					UserMessage = " hello my dear friend how are you? ",
					MessagefromUser = "Все нормально" ,
					StartDate = DateTime.Now,  },
				new MessageModel {
					IsSending= true,
					Contactname="Iam",
					Statusmessage="Recive . .. . . .",
					UserMessage = "I have a question when can we meet? ",
					MessagefromUser = "Какой блэт вопрос?",
				},
				new MessageModel {
					IsSending = false,
					Contactname="Friend",
					Statusmessage="Hi my dear",
					UserMessage = " hello my dear friend how are you? ",
					MessagefromUser = "Все нормально" ,
													},
				new MessageModel {
					IsSending = false,
					Contactname="Friend",
					Statusmessage="qq ....... awdawdw",
					UserMessage = " hello my dear friend how are you? ",
					MessagefromUser = "Все нормально"}
			};

			CloseApplicationCommand = new ActionCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecuted);

			SendCommand = new ActionCommand(o =>
			{
				Users.Add(new MessageModel
				{
					UserMessage = UserMessage,
					IsSending = true
				});
			});
		}
		
		public ICommand CloseApplicationCommand { get; }
		private void OnCloseApplicationCommandExecuted(object p)
		{ Application.Current.Shutdown(); }
		private bool CanCloseApplicationCommandExecuted(object p) { return true; }

	}


}