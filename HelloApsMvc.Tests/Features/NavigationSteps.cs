using System;
using System.IO;
using System.Threading;

using OpenQA.Selenium.Chrome;

using TechTalk.SpecFlow;

namespace HelloApsMvc.Tests
{
	[Binding]
	public class NavigationSteps
	{
		[Given(@"I navigate to the website")]
		public void GivenINavigateToTheWebsite()
		{
			var testRoot = Path.Combine(Environment.CurrentDirectory, "..\\..\\");
			var driver = new ChromeDriver(testRoot);

			driver.Navigate().GoToUrl("http://localhost:49392/");

			Thread.Sleep(5000);
			driver.Dispose();
		}
	}
}