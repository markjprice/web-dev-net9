using Microsoft.Playwright; // To use Playwright, IBrowser, and so on.

using static Microsoft.Playwright.Assertions; // To use Expect.

namespace Northwind.WebUITests;

public class MvcWebUITests
{
  private IBrowser? _browser;
  private IBrowserContext? _session;
  private IPage? _page;
  private IResponse? _response;

  private async Task GotoHomePage(IPlaywright playwright)
  {
    _browser = await playwright.Chromium.LaunchAsync(
      new BrowserTypeLaunchOptions { Headless = true });

    _session = await _browser.NewContextAsync();
    _page = await _session.NewPageAsync();
    _response = await _page.GotoAsync("https://localhost:5021/");
  }

  [Fact]
  public async Task HomePage_Title()
  {
    // Arrange: Launch Chrome browser and navigate to home page.
    // using to make sure Dispose is called at the end of the test.
    using IPlaywright? playwright = await Playwright.CreateAsync();
    await GotoHomePage(playwright);

    string actualTitle = await _page.TitleAsync();

    // Assert: Navigating to home page worked and its title is as expected.
    string expectedTitle = "Home Page - Northwind.Mvc";
    Assert.NotNull(_response);
    Assert.True(_response.Ok);
    Assert.Equal(expectedTitle, actualTitle);

    // Universal sortable ("u") format: 2009-06-15 13:45:30Z
    // : and spaces will cause problems in a filename
    // so replace them with dashes.
    string timestamp = DateTime.Now.ToString("u")
      .Replace(":", "-").Replace(" ", "-");

    await _page.ScreenshotAsync(new PageScreenshotOptions
    {
      Path = Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.Desktop),
        $"homepage-{timestamp}.png")
    });
  }

  [Fact]
  public async Task HomePage_VisitorCount()
  {
    // Arrange: Launch Chrome browser and navigate to home page.
    using IPlaywright? playwright = await Playwright.CreateAsync();
    await GotoHomePage(playwright);

    // The best way to select the element is to use its data-testid.
    ILocator element = _page.GetByTestId("visitor_count");

    // The text content might contain whitespace like \n so we 
    // must trim that away.
    string? countText = (await element.TextContentAsync())?.Trim();

    bool isInteger = int.TryParse(countText, out int count);

    // Assert: Visitor count is as expected.
    Assert.True(isInteger);
    Assert.True(count >= 1 && count <= 1000);
    await Expect(element).ToBeVisibleAsync();
  }

  [Fact]
  public async Task HomePage_FilterProducts()
  {
    // Arrange: Launch Chrome browser and navigate to home page.
    using IPlaywright? playwright = await Playwright.CreateAsync();
    await GotoHomePage(playwright);

    // Set the price input box to 60.
    ILocator price = _page.GetByTestId("price");
    await price.FillAsync("60");

    // Click the submit button to apply the filter.
    ILocator submit = _page.GetByTestId("submit_price");
    await submit.ClickAsync();

    string actualTitle = await _page.TitleAsync();

    // Assert: Navigating to products page worked.
    string expectedTitle = "Products That Cost More Than $60.00 - Northwind.Mvc";
    Assert.NotNull(_response);
    Assert.True(_response.Ok);
    Assert.Equal(expectedTitle, actualTitle);

    string timestamp = DateTime.Now.ToString("u")
      .Replace(":", "-").Replace(" ", "-");

    await _page.ScreenshotAsync(new PageScreenshotOptions
    {
      Path = Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.Desktop),
        $"products-60-{timestamp}.png")
    });
  }
}
