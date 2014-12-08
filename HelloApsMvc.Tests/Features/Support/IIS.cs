using System;
using System.Diagnostics;
using System.IO;

namespace HelloApsMvc.Tests.Features
{
	public class IIS
	{
		private static IIS InstanceField;

		public static IIS Instance
		{
			get { return InstanceField ?? (InstanceField = new IIS()); }
		}

		private Process _iisProcess;

		private string GetApplicationPath(string applicationName)
		{
			var solutionFolder = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)));
			return Path.Combine(solutionFolder, applicationName);
		}

		public void Start()
		{
			if (_iisProcess != null)
			{
				throw new InvalidOperationException("IIS has already been started");
			}
			var applicationPath = GetApplicationPath("HelloApsMvc");
			var programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

			_iisProcess = new Process();
			_iisProcess.StartInfo.FileName = programFiles + @"\IIS Express\iisexpress.exe";
			_iisProcess.StartInfo.Arguments = string.Format("/path:{0} /port:{1}", applicationPath, 49392);
			if (!_iisProcess.Start())
			{
				throw new ApplicationException("IIS-express couldn't be started");
			}
		}

		public void Stop()
		{
			if (_iisProcess == null)
			{
				throw new InvalidOperationException("IIS has not been started");
			}

			_iisProcess.CloseMainWindow();
			_iisProcess = null;
		}
	}
}