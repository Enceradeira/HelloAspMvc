using System;

using HelloApsMvc.Tests.Features;

using NUnit.Framework;

using TechTalk.SpecFlow;

namespace HelloApsMvc.Tests
{
	[Binding]
	public class NavigationSteps : WebSteps
	{
		[Given(@"I navigate to the website")]
		public void GivenINavigateToTheWebsite()
		{
			Driver.Navigate().GoToUrl("http://localhost:49392/");
		}

		[Then(@"I see a list of books")]
		public void ThenISeeAListOfPersons()
		{
			var element = Driver.FindElementById("TitleHeader");
			Assert.That(element, Is.Not.Null);
		}
	}
}