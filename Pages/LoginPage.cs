using Microsoft.Playwright;

namespace BDDReqnrollPlaywrightUI.Pages;

public class LoginPage
{
    private readonly ILocator _btnLogin;
    private readonly ILocator _txtInventryList;
    private readonly ILocator _txtPassword;
    private readonly ILocator _txtUserName;
    private readonly IPage _page;

    public LoginPage(IPage page)
    {
        _page = page;
        _txtUserName = _page.Locator("#user-name");
        _txtPassword = _page.Locator("#password");
        _btnLogin = _page.Locator("#login-button");
        _txtInventryList = _page.Locator("text='Products'");
    }

    public async Task Login(string userName, string password)
    {
        await _txtUserName.FillAsync(userName);
        await _txtPassword.FillAsync(password);
        await _btnLogin.ClickAsync();
    }

    public async Task<bool> IsProductsExists()
    {
        return await _txtInventryList.IsVisibleAsync();
    }
}