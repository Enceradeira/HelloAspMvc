using System;
using System.IO;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace HelloApsMvc.Tests.Features.Support
{
	public class Driver
	{
		private static Driver InstanceField;

		public static Driver Instance
		{
			get { return InstanceField ?? (InstanceField = new Driver()); }
		}

		private ChromeDriver _chromeDriver;

		public RemoteWebDriver RemoteDriver
		{
			get
			{
				if (_chromeDriver == null)
				{
					throw new InvalidOperationException("The driver has not been started");
				}
				return _chromeDriver;
			}
		}

		public void Start()
		{
			if (_chromeDriver != null)
			{
				throw new InvalidOperationException("The driver has already been started");
			}
			var testRoot = Path.Combine(Environment.CurrentDirectory, "..\\..\\");
			_chromeDriver = new ChromeDriver(testRoot);
		}

		public void Stop()
		{
			if (_chromeDriver == null)
			{
				throw new InvalidOperationException("The driver has not been started");
			}
			_chromeDriver.Dispose();
		}
	}
}