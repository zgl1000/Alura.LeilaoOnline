using OpenQA.Selenium;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class LoginPO
    {
        private IWebDriver driver;

        private By byInputLogin;
        private By byInputSenha;
        private By byInputBotaoLogin;

        public LoginPO(IWebDriver driver)
        {
            this.driver = driver;

            byInputLogin = By.Id("Login");
            byInputSenha = By.Id("Password");
            byInputBotaoLogin = By.Id("btnLogin");
        }

        public void Visitar()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Autenticacao/Login");
        }

        public void PreencherFormulario(string login, string senha)
        {
            driver.FindElement(byInputLogin).SendKeys(login);
            driver.FindElement(byInputSenha).SendKeys(senha);
        }

        public void SubmeteFormulario()
        {
            driver.FindElement(byInputBotaoLogin).Click();
        }
    }
}
