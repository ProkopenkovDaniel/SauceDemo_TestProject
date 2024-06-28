using OpenQA.Selenium.Chrome;
using Microsoft.Extensions.Configuration;

namespace Saucedemo_Tests;

public class Tests
{
    public IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        var config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

        driver = new ChromeDriver(config["PuthToWebDriver"]);
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}