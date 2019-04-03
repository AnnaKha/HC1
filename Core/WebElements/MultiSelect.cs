using OpenQA.Selenium;
using System;
using System.Linq;

namespace Core.WebElements
{
	public class MultiSelect : Input
	{
		public MultiSelect(By locator) : base(locator) { }
		public MultiSelect(IWebElement element) : base(element) { }

		public void SetValue(string value)
		{
			if (value != null && !value.Equals(string.Empty))
			{
				WebElement.SendKeys(value);
				RemoveText();
				WebElement.FindElement(By.XPath($"//app-multiselect//button/*[text()='{value}']")).Click();
			}
		}

		public string SelectedValues()
		{
			try
			{
				return String.Join(",", Children(By.XPath($"./ancestor::app-multiselect//span")).Select(i => i.Text.Trim()).ToList());
			}
			catch (NotFoundException)
			{
				return string.Empty;
			}
		}
	}
}