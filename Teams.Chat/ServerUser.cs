﻿using System.ServiceModel;

namespace Teams.Chat
{
	public class ServerUser
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public OperationContext operationcontext { get; set; }
	}
}
