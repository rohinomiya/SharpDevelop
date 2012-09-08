// ユーザ: fukuda
// Last Changed: 2012/08/05 11:48.

using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Rohinomiya
{
	/// <summary>
	/// 例外処理をサポートするクラス
	/// </summary>
    public class HandlerForUnhandledException
    {
    	//TODO: Log4Netと連携するように
    	
        private static HandlerForUnhandledException _singleInstance = new HandlerForUnhandledException();

        // Singletonパターン
        public static HandlerForUnhandledException GetInstance()
        {
            return _singleInstance;
        }

        private HandlerForUnhandledException()
        {
            //TODO: initialization
        }

        public void HandleUnhandledException()
        {
			AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomainUnhandledException);
        }
         
		/// <summary>
		/// try ~ catch で補足されてない例外を処理するイベントハンドラ
		/// </summary>
		/// <param name="sender">送信者</param>
		/// <param name="args">例外オブジェクト</param>
		private void CurrentDomainUnhandledException(object sender, UnhandledExceptionEventArgs args)
		{
			try
			{
				Exception ex = (Exception)args.ExceptionObject;
				
    	//TODO: Log4Netと連携するように
				
				//エラー処理
				MessageBox.Show(GetExceptionInfoString(ex));
			}
			finally
			{
				Application.Exit(); // 明示的に終了させる必要がある
			}
		}
		
		/// <summary>
		/// 例外オブジェクトからデバッグに必要な情報を文字列で返す
		/// </summary>
		/// <param name="ex">例外オブジェクト</param>
		/// <returns>例外情報の文字列</returns>
		public static string GetExceptionInfoString(Exception ex)
		{
			var sb = new StringBuilder();

			sb.AppendFormat("Message={0}\n", ex.Message);
			sb.AppendFormat("Source={0}\n", ex.Source);
			sb.AppendFormat("HelpLink={0}\n", ex.HelpLink);
			sb.AppendFormat("TargetSite={0}\n", ex.TargetSite.ToString());
			sb.AppendFormat("StackTrace={0}\n", ex.StackTrace);

			return sb.ToString();
		}
    }
	
}
