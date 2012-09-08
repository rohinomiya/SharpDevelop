// ユーザ: fukuda
// Last Changed: 2012/08/05 12:32.

using System;
using log4net;

namespace Rohinomiya
{
	/// <summary>
	/// Logger(Log4Net)クラスの Nullオブジェクトパターン
	/// </summary>
	public sealed class NullLogger: ILog
	{
		private static NullLogger _singleInstance = new NullLogger();

				
		public static NullLogger GetInstance()
		{
			return _singleInstance;
		}
		
		private NullLogger()
		{
		}
		
		public bool IsDebugEnabled
		{
			get { return true; }
		}
		
		public bool IsInfoEnabled
		{
			get { return true; }
		}
		
		public bool IsWarnEnabled
		{
			get { return true; }
		}
		
		public bool IsErrorEnabled
		{
			get { return true; }
		}
		
		public bool IsFatalEnabled
		{
			get { return true; }
		}
		
		public void Debug(object message)
		{
		}
		
		public void Debug(object message, Exception exception)
		{
		}

		public void DebugFormat(string format, params object[] args)
		{
		}

		public void DebugFormat(string format, object arg0)
		{
		}

		public void DebugFormat(string format, object arg0, object arg1)
		{
		}

		public void DebugFormat(string format, object arg0, object arg1, object arg2)
		{
		}

		public void DebugFormat(IFormatProvider provider, string format, params object[] args)
		{
		}

		public void Info(object message)
		{
		}

		public void Info(object message, Exception exception)
		{
		}

		public void InfoFormat(string format, params object[] args)
		{
		}

		public void InfoFormat(string format, object arg0)
		{
		}

		public void InfoFormat(string format, object arg0, object arg1)
		{
		}

		public void InfoFormat(string format, object arg0, object arg1, object arg2)
		{
		}

		public void InfoFormat(IFormatProvider provider, string format, params object[] args)
		{
		}

		public void Warn(object message)
		{
		}

		public void Warn(object message, Exception exception)
		{
		}

		public void WarnFormat(string format, params object[] args)
		{
		}

		public void WarnFormat(string format, object arg0)
		{
		}

		public void WarnFormat(string format, object arg0, object arg1)
		{
		}

		public void WarnFormat(string format, object arg0, object arg1, object arg2)
		{
		}

		public void WarnFormat(IFormatProvider provider, string format, params object[] args)
		{
		}

		public void Error(object message)
		{
		}

		public void Error(object message, Exception exception)
		{
		}

		public void ErrorFormat(string format, params object[] args)
		{
		}

		public void ErrorFormat(string format, object arg0)
		{
		}

		public void ErrorFormat(string format, object arg0, object arg1)
		{
		}

		public void ErrorFormat(string format, object arg0, object arg1, object arg2)
		{
		}

		public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
		{
		}

		public void Fatal(object message)
		{
		}

		public void Fatal(object message, Exception exception)
		{
		}

		public void FatalFormat(string format, params object[] args)
		{
		}

		public void FatalFormat(string format, object arg0)
		{
		}


		public void FatalFormat(string format, object arg0, object arg1)
		{
		}

		public void FatalFormat(string format, object arg0, object arg1, object arg2)
		{
		}

		public void FatalFormat(IFormatProvider provider, string format, params object[] args)
		{
		}

		//CS0535 対応
		//(http://old.nabble.com/-jira---Created--(LOG4NET-326)-Add-a-null-logger-implementation-td33520340.html)
		public global::log4net.Core.ILogger Logger
		{
			get { return null; }
		}
	}
	
}
