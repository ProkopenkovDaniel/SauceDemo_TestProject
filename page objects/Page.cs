using Microsoft.Extensions.Configuration;
using OpenQA.Selenium.Chrome;

namespace Saucedemo_Tests;

public abstract class Page
{
    protected IWebDriver driver;

    /// <summary>
    /// Initializes Configuration object - will repeats with every new page object. 
    /// Initializes WebDriver object
    /// </summary>
    protected Page(){
        
    }
}