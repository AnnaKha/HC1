﻿using OpenQA.Selenium;

namespace Core.WebElements
{
	public class Input : Element
	{
		public Input(By locator) : base(locator) { }
		public Input(IWebElement element) : base(element) { }

		public void SetText(string text)
		{
			if (text != null && !text.Equals(string.Empty))
			{
				RemoveText();
				WebElement.SendKeys(text);
			}
		}

		public void RemoveText()
		{
			WebElement.SendKeys(Keys.Control + "a");
			WebElement.SendKeys(Keys.Delete);
		}
	}
}
