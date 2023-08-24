using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SpecFlowTask.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowTask.Utilities;
using NUnit.Framework;

namespace SpecFlowTask.Tests
{
    public class LangSkill_Tests : CommonDriver
    {
        [SetUp]
        public void SetUpActions()
        {
            driver = new ChromeDriver();

            //Login page object initialization and definition
            LoginAndJoinPage loginAndJoinPageObj = new LoginAndJoinPage();
            loginAndJoinPageObj.LoginSteps(driver);
        }

        [Test]
        public void AddLanguage_Test()
        {

            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.CreateLanguage(driver);
        }

        [Test]
        public void EditLanguage_Test()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            //lanAndSkillPageObj.UpdateLanguage(driver);
        }

        [Test]
        public void DeleteLanguage_Test()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.DeleteLanguage(driver);
        }

        [Test]
        public void AddSkill_Test()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.CreateSkill(driver);
        }

        [Test]
        public void EditSkill_Test()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            //lanAndSkillPageObj.UpdateSkill(driver);
        }

        [Test]
        public void DeleteSkill_Test()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.DeleteSkill(driver);
        }

        [TearDown]
        public void CloseTesRun()
        {
            driver.Quit();
        }
    }
}
