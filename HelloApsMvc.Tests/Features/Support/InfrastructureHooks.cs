using System;
using HelloApsMvc.Tests.Features.Support;
using TechTalk.SpecFlow;

namespace HelloApsMvc.Tests.Features
{
	[Binding]
	public class InfrastructureHooks
	{
		[AfterTestRun]
		public static void AfterTestRun()
		{
			IIS.Instance.Stop();
			Driver.Instance.Stop();
		}

		[BeforeTestRun]
		public static void BeforeTestRun()
		{
			var cleaning = DatabaseCleaner.Clean();
			IIS.Instance.Start();
			Driver.Instance.Start();
			cleaning.Wait();
		}
	}
}