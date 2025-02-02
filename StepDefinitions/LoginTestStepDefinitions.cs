using BDDReqnrollPlaywrightUI.Drivers;
using BDDReqnrollPlaywrightUI.Pages;
using System;
using Reqnroll;

namespace BDDReqnrollPlaywrightUI.StepDefinitions
{
    [Binding]
    public class LoginTestStepDefinitions
    {
        private readonly Driver _driver;
        private readonly LoginPage _loginPage;

        public LoginTestStepDefinitions(Driver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver.Page);
        } 

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driver.Page.GotoAsync("https://www.saucedemo.com");
        }

        [Given(@"I enter following login details")]
        public async Task GivenIEnterFollowingLoginDetails()
        {
            await _loginPage.Login("standard_user", "secret_sauce");
        }

        [Then(@"I see Inventry list")]
        public async Task ThenISeeInventryList()
        {
            var isExist = await _loginPage.IsProductsExists();
            isExist.Should().BeTrue();
        }
    }
}
