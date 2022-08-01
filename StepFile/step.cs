using System;
using TechTalk.SpecFlow;
using Demo1.CommonObjectMethod;
using Demo1.utilities;
using OpenQA.Selenium;
using System.Threading;

namespace Demo1.StepFile
{
    [Binding]
    public class VerificationSteps
    {
        CommonMethod obj = new CommonMethod();

        [Given(@"load the oralB application")]
        public void GivenLoadTheOralBApplication()
        {
            obj.OpenURL();
        }
        
        [When(@"u click on kid's brushes from dropdown")]
        public void WhenUClickOnKidSBrushesFromDropdown()
        {
            obj.ClickOn();
        }
        
        [Then(@"verify the text kid's is diplayed")]
        public void ThenVerifyTheTextKidSIsDiplayed()
        {
            obj.TextVerification();
        }

        [Given(@"load the website")]
        public void GivenLoadTheWebsite()
        {
            obj.OpenURL1();
        }

        [When(@"click on search icon on the top right corner")]
        public void WhenClickOnSearchIconOnTheTopRightCorner()
        {
            
                 obj.ClickOnSearch();
        }

        [When(@"type battery in searchbox ""(.*)""")]
        public void WhenTypeBatteryInSearchbox(string p0)
        {
            Thread.Sleep(3000);
            BaseClass.driver.FindElement(By.XPath("//input[@id='searchText']")).SendKeys(p0);
            obj.typebattery();
        }

        [When(@"select first link")]
        public void WhenSelectFirstLink()
        {
            obj.selectfirstlink();
        }

        [Then(@"verify the text battery is dipalyed")]
        public void ThenVerifyTheTextBatteryIsDipalyed()
        {
            obj.isdisplayed();
        }

        [Given(@"load the web page")]
        public void GivenLoadTheWebPage()
        {
            obj.OpenURL2();
        }

        [When(@"click on floss under shop in footer")]
        public void WhenClickOnFlossUnderShopInFooter()
        {
            obj.clickonfloss();
        }

        [Then(@"verify floss picks appearing in the list products")]
        public void ThenVerifyFlossPicksAppearingInTheListProducts()
        {
            obj.flossverification();
        }

        [Then(@"take a screen short")]
        public void ThenTakeAScreenShort()
        {
            obj.screenshort();
        }





    }
}
