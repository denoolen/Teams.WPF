using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Teams.WPF
{
	// ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IServiceChat" в коде и файле конфигурации.
	[ServiceContract(CallbackContract = typeof (IServiceChatCallback))]
	public interface IServiceChat
	{
		[OperationContract]
		int Connect();
		[OperationContract]
		void Disconnect(int id);

		[OperationContract(IsOneWay = true)]
		void SendMsg(string msg);
	}
	public interface IServiceChatCallback
	{
		[OperationContract]
		void MsgCallback(string msg);
	}
}
