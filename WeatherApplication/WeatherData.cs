using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication
{
    internal class WeatherData
    {
        public string GetWeatherData(string cityName) 
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement ele2 = driver.FindElement(By.Id("W0wltc"));
            ele2.Click();
            IWebElement ele = driver.FindElement(By.Name("q"));
            ele.SendKeys(cityName + " Weather");
            ele.Submit();
            IWebElement Temp = driver.FindElement(By.Id("wob_tm"));
            IWebElement TimenDate = driver.FindElement(By.Id("wob_dts"));
            IWebElement WeatherType = driver.FindElement(By.Id("wob_dc"));
            string result = cityName + " is " + Temp.Text + " Degrees " + TimenDate.Text + " " + WeatherType.Text;
            driver.Close();
            Console.WriteLine(result);
            return result;
        }
    }
}
