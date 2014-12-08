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

		[Then(@"I can enter a new book")]
		public void ThenICanEnterANewBook()
		{
			Assert.That(() => Driver.FindElementById("TitleEditor"), Throws.Nothing);
		}

		[Then(@"I see a list of books")]
		public void ThenISeeAListOfPersons()
		{
			var element = Driver.FindElementById("TitleHeader");
			Assert.That(element, Is.Not.Null);
		}

		[When(@"I click on create book")]
		public void WhenIClickOnCreateBook()
		{
			var element = Driver.FindElementById("CreateNewBook");
			element.Click();
		}
	}
}