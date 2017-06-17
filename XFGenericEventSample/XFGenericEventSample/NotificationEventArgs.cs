using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFGenericEventSample
{
	public class NotificationEventArgs<T> : EventArgs
	{
		public T Message { get; set; }
	}
}
