using OpenQA.Selenium;
using System;

namespace UnitTestProject1
{
	internal class SampleApplicationPageTest
	{
		private IWebDriver Driver { get; set; }

		public SampleApplicationPageTest(IWebDriver driver)
		{
			Driver = driver;
		}

		internal void maximizeWindow()
		{
			Driver.Manage().Window.Maximize();
		}

		public bool IsVisible
		{
			get
			{
				return Driver.Title.Contains("Sample Application Lifecycle - Sprint 1 - Ultimate QA");
			}
			internal set { }
		}

		public IWebElement FirstNameField => Driver.FindElement(By.Name("firstname"));

		public IWebElement SubmitButton => Driver.FindElement(By.Id("submitForm"));

		internal void GoTo()
		{
			Driver.Navigate().GoToUrl("https://www.ultimateqa.com/sample-application-lifecycle-sprint-1/");
		}

		internal UltimateQAHomePage FillOutFormAndSubmit(string firstName)
		{

			FirstNameField.SendKeys(firstName);
			SubmitButton.Click();
			return new UltimateQAHomePage(Driver);
		}

	}	
}
