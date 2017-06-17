using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFGenericEventSample
{
public class Notificator<T>
{
	public event EventHandler<NotificationEventArgs<T>> Notified;

	public void NotifyMessage(T message)
	{
		Notified?.Invoke(this, new NotificationEventArgs<T>{ Message = message});
	}
}
}
