using System;
using System.IO;
using System.Threading;

using HelloApsMvc.Tests.Features;
using HelloApsMvc.Tests.Features.Support;

using OpenQA.Selenium.Chrome;

using TechTalk.SpecFlow;

namespace HelloApsMvc.Tests
{
	[Binding]
	public class NavigationSteps: WebSteps
	{
		[Given(@"I navigate to the website")]
		public void GivenINavigateToTheWebsite()
		{
			Driver.Navigate().GoToUrl("http://localhost:49392/");
		}

		[Then(@"I see a list of persons")]
		public void ThenISeeAListOfPersons()
		{
			ScenarioContext.Current.Pending();
		}

	}
}