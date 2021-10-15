using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Teams.Chat
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
	// ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ServiceChat" в коде и файле конфигурации.
	public class ServiceChat : IServiceChat
	{
		List<ServerUser> users = new List<ServerUser>();
		int UserID = 1;
		public int Connect(string name)
		{
			ServerUser user = new ServerUser()
			{
				ID = UserID,
				Name = name,
				operationcontext = OperationContext.Current,
			};
			UserID++;

			SendMsg(user.Name + " подключен", 0);
			users.Add(user);
			return user.ID;

		}



		public void Disconnect(int id)
		{
			var user = users.FirstOrDefault(i => i.ID == id);
			if (user != null)
			{
				users.Remove(user);
				SendMsg(user.Name + " покинул чат", 0);
			}
		}

		public void DoWork()
		{
		}

		public void SendMsg(string msg, int id)
		{
			foreach (var item in users)
			{
				string ansver = DateTime.Now.ToShortTimeString();
				var user = users.FirstOrDefault(i => i.ID == id);
				if (user != null)
				{
					ansver += ": " + user;

				}
				ansver += msg;
				item.operationcontext.GetCallbackChannel<IServiceChatCallback>().MsgCallback(ansver);
			}
		}


	}
}
