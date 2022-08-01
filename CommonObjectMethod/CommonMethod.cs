using Demo1.utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo1.CommonObjectMethod
{
    public class CommonMethod
    {
        public void OpenURL()
        {
            BaseClass.driver.Navigate().GoToUrl("https://www.oral-b.co.in/en-in/products/electric-toothbrushes/?gclid=EAIaIQobChMI946-gcT3-AIVllpgCh1DagXyEAAYASAAEgJ3ePD_BwE");

        }
        public void ClickOn()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-in/products/kids-toothbrushes']")).Click();
        }
        public void TextVerification()
        {
            string text = BaseClass.driver.FindElement(By.XPath("//p[@class='ob-eyebrow']")).Text;
            if(text.Contains("KIDS"))
            {
                Console.WriteLine("text kids is present");
            }
            else
            {
                Console.WriteLine("text kid is not present");
            }
        }


        public void OpenURL1()
        {
            BaseClass.driver.Navigate().GoToUrl("https://www.oral-b.co.in/en-in/products/electric-toothbrushes/?gclid=EAIaIQobChMI946-gcT3-AIVllpgCh1DagXyEAAYASAAEgJ3ePD_BwE");

        }

        public void ClickOnSearch()
        {
            BaseClass.driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-in/search']")).Click();

        }
        public void typebattery()
        {
            Thread.Sleep(4000);
            BaseClass.driver.FindElement(By.XPath("//button[@class ='ob-search-bar-icon']")).Click();

        }
        public void selectfirstlink()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='https://www.oral-b.co.in/en-in/products/battery-powered-toothbrushes']")).Click();
        }
        public void isdisplayed()
        {
            Thread.Sleep(3000);
            string text = BaseClass.driver.FindElement(By.XPath("//h1[@class='ob-heading ob-display-2-xl']")).Text;
            Thread.Sleep(3000);
            if (text.Contains("barrtey"))
            {
                Console.WriteLine("battery text is present");

            }
            else
            {
                Console.WriteLine("battery text is not present");
            }

        }
        public void OpenURL2()
        {
            BaseClass.driver.Navigate().GoToUrl("https://www.oral-b.co.in/en-in/products/electric-toothbrushes/?gclid=EAIaIQobChMI946-gcT3-AIVllpgCh1DagXyEAAYASAAEgJ3ePD_BwE");

        }

        public void clickonfloss()
        {
            BaseClass.driver.Manage().Window.Minimize();
            Thread.Sleep(2000);
            BaseClass.driver.FindElement(By.XPath("//a[@aria-label = 'Floss-callToActionLink']")).Click();
        }
        public void flossverification()

        {
            Thread.Sleep(3000);
            string text = BaseClass.driver.FindElement(By.XPath("//h1[@class='ob-heading ob-display-2-xl']")).Text;
            if (text.Contains(" floss picks "))
            {
                Console.WriteLine("floss present");
            }
            else 
            {
                Console.WriteLine("floss not present");
            }
        }
        public void screenshort()
        {
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile("battery.png");
        }


    }
}
