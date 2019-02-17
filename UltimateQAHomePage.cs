using OpenQA.Selenium;

namespace UnitTestProject1
{
	internal class UltimateQAHomePage
	{
		private IWebDriver Driver { get; set; }

		public UltimateQAHomePage (IWebDriver driver)
		{
			Driver = Driver;
		}

		public bool IsVisible => StartHereButton.Displayed;

		public IWebElement StartHereButton => Driver.FindElement(By.LinkText("Start here"));
	}
}