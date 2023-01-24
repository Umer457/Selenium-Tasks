using NUnit.Framework;
using Altom.AltUnityDriver;

public class TestsForPolka
{
    public AltUnityDriver altUnityDriver;
    //Before any test it connects with the socket
    [OneTimeSetUp]
    public void SetUp()
    {
        altUnityDriver = new AltUnityDriver();
    }

    //At the end of the test closes the connection with the socket
    [OneTimeTearDown]
    public void TearDown()
    {
        altUnityDriver.Stop();
    }

    [Test]
    public void WhenOnlyUsernameIsEntered()
    {
        altUnityDriver.LoadScene("MainScene");
        const string username = "UsernameInputField(TMP)";
        const string usernametext = "polkatest1";
        var inputname = altUnityDriver.FindObject(By.NAME, username).SetText(usernametext, true);
        Assert.NotNull(inputname);
        Assert.AreEqual(inputname.GetText(), usernametext);

        altUnityDriver.FindObject(By.NAME, "LogInButton").Click();

    }
    [Test]
    public void WhenOnlyPasswordIsEntered()
    {
        altUnityDriver.LoadScene("MainScene");
        const string password1 = "PasswordInputField(TMP)";
        const string text = "565656polka";
        var inputpassword = altUnityDriver.FindObject(By.NAME, password1).SetText(text, true);
        Assert.NotNull(inputpassword);
        Assert.AreEqual(inputpassword.GetText(), text);

        altUnityDriver.FindObject(By.NAME, "LogInButton").Click();

    }
    [Test]
    public void WhenUsernameAndPasswordAreCorrect()
    {
        altUnityDriver.LoadScene("MainScene");
        const string username = "UsernameInputField(TMP)";
        const string usernametext = "polkatest1";
        var inputname = altUnityDriver.FindObject(By.NAME, username).SetText(usernametext, true);
        Assert.NotNull(inputname);
        Assert.AreEqual(inputname.GetText(), usernametext);

        const string password1 = "PasswordInputField(TMP)";
        const string text = "565656polka";
        var inputpassword = altUnityDriver.FindObject(By.NAME, password1).SetText(text, true);
        Assert.NotNull(inputpassword);
        Assert.AreEqual(inputpassword.GetText(), text);

        altUnityDriver.FindObject(By.NAME, "LogInButton").Click();

    }
    [Test]
    public void WhenUsernameAndPasswordAreIncorrect()
    {
        altUnityDriver.LoadScene("MainScene");
        const string username = "UsernameInputField(TMP)";
        const string usernametext = "polkatest12";
        var inputname = altUnityDriver.FindObject(By.NAME, username).SetText(usernametext, true);
        Assert.NotNull(inputname);
        Assert.AreEqual(inputname.GetText(), usernametext);

        const string password1 = "PasswordInputField(TMP)";
        const string text = "565656polkaa";
        var inputpassword = altUnityDriver.FindObject(By.NAME, password1).SetText(text, true);
        Assert.NotNull(inputpassword);
        Assert.AreEqual(inputpassword.GetText(), text);

        altUnityDriver.FindObject(By.NAME, "LogInButton").Click();

    }
    [Test]
    public void WhenUsernameIsincorrectButPasswordIsCorrect()
    {
        altUnityDriver.LoadScene("MainScene");
        const string username = "UsernameInputField(TMP)";
        const string usernametext = "polkatest1t";
        var inputname = altUnityDriver.FindObject(By.NAME, username).SetText(usernametext, true);
        Assert.NotNull(inputname);
        Assert.AreEqual(inputname.GetText(), usernametext);

        const string password1 = "PasswordInputField(TMP)";
        const string text = "565656polka";
        var inputpassword = altUnityDriver.FindObject(By.NAME, password1).SetText(text, true);
        Assert.NotNull(inputpassword);
        Assert.AreEqual(inputpassword.GetText(), text);

        altUnityDriver.FindObject(By.NAME, "LogInButton").Click();

    }
    [Test]
    public void WhenUsernameIscorrectButPasswordIsIncorrect()
    {
        altUnityDriver.LoadScene("MainScene");
        const string username = "UsernameInputField(TMP)";
        const string usernametext = "polkatest1";
        var inputname = altUnityDriver.FindObject(By.NAME, username).SetText(usernametext, true);
        Assert.NotNull(inputname);
        Assert.AreEqual(inputname.GetText(), usernametext);

        const string password1 = "PasswordInputField(TMP)";
        const string text = "565656polkaQ";
        var inputpassword = altUnityDriver.FindObject(By.NAME, password1).SetText(text, true);
        Assert.NotNull(inputpassword);
        Assert.AreEqual(inputpassword.GetText(), text);

        altUnityDriver.FindObject(By.NAME, "LogInButton").Click();

    }
    [Test]
    public void LoadIventory()
    {
        altUnityDriver.LoadScene("MainScene");
        const string username = "UsernameInputField(TMP)";
        const string usernametext = "polkatest1";
        var inputname = altUnityDriver.FindObject(By.NAME, username).SetText(usernametext, true);
        Assert.NotNull(inputname);
        Assert.AreEqual(inputname.GetText(), usernametext);

        const string password1 = "PasswordInputField(TMP)";
        const string text = "565656polka";
        var inputpassword = altUnityDriver.FindObject(By.NAME, password1).SetText(text, true);
        Assert.NotNull(inputpassword);
        Assert.AreEqual(inputpassword.GetText(), text);

        altUnityDriver.FindObject(By.NAME, "LogInButton").Click();

        var loadInventoryButton = altUnityDriver.WaitForObjectWhichContains(By.NAME, "InventoryButton");
        Assert.AreEqual("InventoryButton", loadInventoryButton.name);
        System.Threading.Thread.Sleep(5500);
        altUnityDriver.FindObject(By.NAME, "InventoryButton").Click();

    }
    [Test]
    public void ChangeHaitStyle()
    {
        altUnityDriver.LoadScene("MainScene");
        const string username = "UsernameInputField(TMP)";
        const string usernametext = "polkatest1";
        var inputname = altUnityDriver.FindObject(By.NAME, username).SetText(usernametext, true);
        Assert.NotNull(inputname);
        Assert.AreEqual(inputname.GetText(), usernametext);

        const string password1 = "PasswordInputField(TMP)";
        const string text = "565656polka";
        var inputpassword = altUnityDriver.FindObject(By.NAME, password1).SetText(text, true);
        Assert.NotNull(inputpassword);
        Assert.AreEqual(inputpassword.GetText(), text);

        altUnityDriver.FindObject(By.NAME, "LogInButton").Click();



    }
    [Test]
    public void ViewCityControls()

    {
        altUnityDriver.LoadScene("MainScene");
        const string username = "UsernameInputField(TMP)";
        const string usernametext = "polkatest1";
        var inputname = altUnityDriver.FindObject(By.NAME, username).SetText(usernametext, true);
        Assert.NotNull(inputname);
        Assert.AreEqual(inputname.GetText(), usernametext);

        const string password1 = "PasswordInputField(TMP)";
        const string text = "565656polka";
        var inputpassword = altUnityDriver.FindObject(By.NAME, password1).SetText(text, true);
        Assert.NotNull(inputpassword);
        Assert.AreEqual(inputpassword.GetText(), text);
        altUnityDriver.FindObject(By.NAME, "LogInButton").Click();
        System.Threading.Thread.Sleep(2500);

        altUnityDriver.FindObject(By.NAME, "SettingsButton").Click();
        System.Threading.Thread.Sleep(1500);
        altUnityDriver.FindObject(By.NAME, "ControlsButton").Click();
        altUnityDriver.FindObject(By.NAME, "CityViewControlsButton").Click();

    }
    [Test]
    public void ViewPlayerControls()

    {
        altUnityDriver.LoadScene("MainScene");
        const string username = "UsernameInputField(TMP)";
        const string usernametext = "polkatest1";
        var inputname = altUnityDriver.FindObject(By.NAME, username).SetText(usernametext, true);
        Assert.NotNull(inputname);
        Assert.AreEqual(inputname.GetText(), usernametext);

        const string password1 = "PasswordInputField(TMP)";
        const string text = "565656polka";
        var inputpassword = altUnityDriver.FindObject(By.NAME, password1).SetText(text, true);
        Assert.NotNull(inputpassword);
        Assert.AreEqual(inputpassword.GetText(), text);
        altUnityDriver.FindObject(By.NAME, "LogInButton").Click();
        System.Threading.Thread.Sleep(2500);

        altUnityDriver.FindObject(By.NAME, "SettingsButton").Click();
        System.Threading.Thread.Sleep(1500);
        altUnityDriver.FindObject(By.NAME, "ControlsButton").Click();
        altUnityDriver.FindObject(By.NAME, "PlayerViewControlsButton").Click();
    }
    [Test]
    public void CheckCameraPanningValue()


    {
        altUnityDriver.LoadScene("MainScene");
        const string username = "UsernameInputField(TMP)";
        const string usernametext = "polkatest1";
        var inputname = altUnityDriver.FindObject(By.NAME, username).SetText(usernametext, true);
        Assert.NotNull(inputname);
        Assert.AreEqual(inputname.GetText(), usernametext);

        const string password1 = "PasswordInputField(TMP)";
        const string text = "565656polka";
        var inputpassword = altUnityDriver.FindObject(By.NAME, password1).SetText(text, true);
        Assert.NotNull(inputpassword);
        Assert.AreEqual(inputpassword.GetText(), text);
        altUnityDriver.FindObject(By.NAME, "LogInButton").Click();

        System.Threading.Thread.Sleep(2500);

        altUnityDriver.FindObject(By.NAME, "SettingsButton").Click();
        System.Threading.Thread.Sleep(1500);
        altUnityDriver.FindObject(By.NAME, "CameraButton").Click();
        var cameraSliderValue = altUnityDriver.FindObject(By.NAME, "PanningSensitivityPropertySlider").GetComponentProperty<float>("UnityEngine.UI.Slider", "value");
        Assert.AreEqual(cameraSliderValue, 267.0);


    }
    [Test]
    public void ChangeCameraPanningValue()

    {
        altUnityDriver.LoadScene("MainScene");
        const string username = "UsernameInputField(TMP)";
        const string usernametext = "polkatest1";
        var inputname = altUnityDriver.FindObject(By.NAME, username).SetText(usernametext, true);
        Assert.NotNull(inputname);
        Assert.AreEqual(inputname.GetText(), usernametext);

        const string password1 = "PasswordInputField(TMP)";
        const string text = "565656polka";
        var inputpassword = altUnityDriver.FindObject(By.NAME, password1).SetText(text, true);
        Assert.NotNull(inputpassword);
        Assert.AreEqual(inputpassword.GetText(), text);
        altUnityDriver.FindObject(By.NAME, "LogInButton").Click();

        System.Threading.Thread.Sleep(2500);

        altUnityDriver.FindObject(By.NAME, "SettingsButton").Click();
        System.Threading.Thread.Sleep(1500);
        altUnityDriver.FindObject(By.NAME, "CameraButton").Click();
        var sliderValue = altUnityDriver.FindObject(By.NAME, "PanningSensitivityPropertySlider");
        Assert.NotNull(sliderValue);
        sliderValue.SetComponentProperty("UnityEngine.UI.Slider", "value", "400.0");
        var newSliderValue = sliderValue.GetComponentProperty<string>("UnityEngine.UI.Slider", "value");
        Assert.AreEqual("400.0", newSliderValue);
         
    }
}
