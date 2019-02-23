using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace UnitTestProject1
{
	internal class SampleApplicationPageTest : BaseSampleApplicationPage
	{
		

		public SampleApplicationPageTest(IWebDriver driver) : base(driver) { }

		internal void maximizeWindow()
		{
			Driver.Manage().Window.Maximize();
		}

		public IWebElement FirstNameField => Driver.FindElement(By.Name("firstname"));

		public IWebElement SubmitButton => Driver.FindElement(By.CssSelector("//*[@type='submit']"));

		public IWebElement LastNameField => Driver.FindElement(By.Name("lastname"));

		public IWebElement FemaleGenderRadioButton => Driver.FindElement(By.XPath("[@id='post - 934']/div/form/input[2]"));

		private string PageTitle => "Sample Application Lifecycle - Sprint 2 - Ultimate QA";


		public bool IsVisible
		{
			get
			{
				return Driver.Title.Contains(PageTitle);
			}
			internal set { }
		}

		

		internal void GoTo()
		{
			Driver.Navigate().GoToUrl("https://www.ultimateqa.com/sample-application-lifecycle-sprint-3/");
			Assert.IsTrue(IsVisible, $"Sample application page was not visible. Expected =>{PageTitle}." + $"Actual => { Driver.Title}" );
		}

		internal UltimateQAHomePage FillOutFormAndSubmit(TestUser user)
		{
			SetGender(user);
			FirstNameField.SendKeys(user.FirstName);
			LastNameField.SendKeys(user.LastName);
			SubmitButton.Click();



			return new UltimateQAHomePage(Driver);
		}

		private void SetGender(TestUser user)
		{
			switch (user.GenderType)
			{
				case Gender.Male:
					break;
				case Gender.Female:
					FemaleGenderRadioButton.Click();
					break;
				case Gender.Other:
					break;
			}
		}
	}
}
