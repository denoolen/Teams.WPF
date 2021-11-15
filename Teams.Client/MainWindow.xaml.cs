using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Teams.Client.MVVM.Model;
using Teams.Client.MVVM;	
using Teams.Client.ServiceChat;

namespace Teams.Client
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
		//, IServiceChatCallback
	{
		//bool IsConnected = false;
		//int ID;
		//ServiceChatClient client;
		
		public MainWindow()
		{
			InitializeComponent();
			
		}
		//void ConnectUser()
		//{
			
		//	if (!IsConnected)
		//	{
		//		client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
		//		ID = client.Connect(searchTextBox.Text);
		//		searchTextBox.IsEnabled = false;
		//		//MessageBox.Show("Hello");
		//		TBConnect.Text = "Disconnect";
		//		IsConnected = true;
		//	}
		//}
		//void DisconnectUser()
		//{
		//	if (IsConnected)
		//	{
		//		client.Disconnect(ID);
		//		client = null;
		//		searchTextBox.IsEnabled = true;
		//		TBConnect.Text = "Connect";
		//		IsConnected = false;
		//	}
		//}

		private void Head_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if(e.LeftButton == MouseButtonState.Pressed)
			{
				DragMove();
			}
		}

		private void ButtonMinimaze_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.MainWindow.WindowState = WindowState.Minimized;
		}


		private void WindowStateButton_Click(object sender, RoutedEventArgs e)
		{
			if(Application.Current.MainWindow.WindowState != WindowState.Maximized)
				Application.Current.MainWindow.WindowState= WindowState.Maximized;
			else
				Application.Current.MainWindow.WindowState = WindowState.Normal;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			
		}

		//private void ConnectUser(object sender, RoutedEventArgs e)
		//{
		//	if (IsConnected)
		//	{
		//		DisconnectUser();
		//	}
		//	else
		//	{
		//		ConnectUser();
		//	}

		//}

		//public void MsgCallback(string msg)
		//{
		//	LbChat.Items.Add(msg);
		//}

		//private void SendTextBox_KeyDown(object sender, KeyEventArgs e)
		//{
		//	if(e.Key == Key.Enter)
		//	{
		//		if (client != null)
		//		{
		//			client.SendMsg(searchTextBox.Text, ID);
		//			SendTextBox.Text = String.Empty;	
		//		}

		//	}
		//}
	}
}
