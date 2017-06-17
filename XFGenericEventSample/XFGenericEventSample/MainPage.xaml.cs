using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFGenericEventSample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			//MyNotificator.Notified += OnNotified;
		}

		private void OnNotified(object sender, NotificationEventArgs<string> e)
		{
			MyLabel.Text = e.Message;
		}

		private void Button_OnClicked(object sender, EventArgs e)
		{
			MyNotificator.NotifyMessage("Message.");
		}
	}
}
