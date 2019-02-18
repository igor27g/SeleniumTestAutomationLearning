using OpenQA.Selenium;

namespace UnitTestProject1
{
	internal class BaseSampleApplicationPage
	{

		protected IWebDriver Driver { get; set; }

		public BaseSampleApplicationPage(IWebDriver driver)
		{
			Driver = driver;
		}

	}
}