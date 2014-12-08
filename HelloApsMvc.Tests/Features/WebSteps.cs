using System;

using OpenQA.Selenium.Remote;

namespace HelloApsMvc.Tests.Features
{
	public class WebSteps
	{
		protected RemoteWebDriver Driver
		{
			get { return Support.Driver.Instance.RemoteDriver; }
		}
	}
}