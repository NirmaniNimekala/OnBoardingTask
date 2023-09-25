using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SpecFlowTask.Pages;
using SpecFlowTask.Utilities;
using System;
using System.Reflection.Emit;
using TechTalk.SpecFlow;

namespace SpecFlowTask.StepDefinitions
{
    [Binding]
    public class LangSkillStepDefinitions : CommonDriver
    {
        //Login Functionality
        [Given(@"I logged into the website successfully and navigate to profile page")]
        public void GivenILoggedIntoTheWebsiteSuccessfullyAndNavigateToProfilePage()
        {
            driver = new ChromeDriver();

            //Login page object initialization and definition
            LoginAndJoinPage loginAndJoinPageObj = new LoginAndJoinPage();
            loginAndJoinPageObj.LoginSteps(driver);
        }

        [When(@"I add New Language to the Languages")]
        public void WhenIAddNewLanguageToTheLanguages()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.CreateLanguage(driver);
        }

        [Then(@"The Language should be added successfully")]
        public void ThenTheLanguageShouldBeAddedSuccessfully()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();

            string NewLanguage = lanAndSkillPageObj.GetLanguage(driver);
            Assert.That(lanAndSkillPageObj.GetLanguage(driver) == "Sinhala");
        }

        [When(@"I add multiple '([^']*)' and '([^']*)' to the Languages")]
        public void WhenIAddMultipleAndToTheLanguages(string language, string level)
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.AddMultipleLanguage(driver, language, level);
        }

        [Then(@"I am able to see up to four languages in the list")]
        public void ThenIAmAbleToSeeUpToFourLanguagesInTheList()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.CheckAddNewButtonPresent(driver);
        }


        [When(@"I edit '([^']*)' in the language list")]
        public void WhenIEditInTheLanguageList(string language)
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.UpdateLanguage(driver, language);
        }

        [Then(@"'([^']*)' is updated successfully")]
        public void ThenIsUpdatedSuccessfully(string language)
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            string Newlanguage = lanAndSkillPageObj.GetEditedLanguage(driver);
        }

        [When(@"I delete a langugae in the language list")]
        public void WhenIDeleteALangugaeInTheLanguageList()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.DeleteLanguage(driver);
        }

        [Then(@"The Language should be deleted")]
        public void ThenTheLanguageShouldBeDeleted()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.GetDeletedLanguage(driver);
        }

        //skills Add modify and delete

        [When(@"I add New Skill to the Skills")]
        public void WhenIAddNewSkillToTheSkills()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.CreateSkill(driver);
        }

        [Then(@"The Skill should be added successfully")]
        public void ThenTheSkillShouldBeAddedSuccessfully()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            string newSkill = lanAndSkillPageObj.GetSkills(driver);
            Assert.That(lanAndSkillPageObj.GetSkills(driver) == "Test Automation");
        }

        [When(@"I edit '([^']*)' in the skills list")]
        public void WhenIEditInTheSkillsList(string skill)
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.UpdateSkill(driver, skill);
        }

        [Then(@"'([^']*)' is updated successfully in skill list")]
        public void ThenIsUpdatedSuccessfullyInSkillList(string skill)
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            string NewSkill = lanAndSkillPageObj.GetEditedLanguage(driver);
        }

        //Cancel button the language tab
        [When(@"I click add new '([^']*)' and '([^']*)' and I click cancel button")]
        public void WhenIClickAddNewAndAndIClickCancelButton(string language, string level)
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.CancelAddingLanguage(driver, language, level);
        }

        [Then(@"I am able to see existing previously added languages")]
        public void ThenIAmAbleToSeeExistingPreviouslyAddedLanguages()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            string lastRecord = lanAndSkillPageObj.CheckFields(driver);
            Assert.That(lastRecord != "English", "Record has added Cancel function is not working");
        }

        //Cancel button in the Skill tabs
        [When(@"I click add new '([^']*)' and '([^']*)' and I click cancel button in skill section")]
        public void WhenIClickAddNewAndAndIClickCancelButtonInSkillSection(string skill, string level)
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.CancelAddingSkill(driver, skill, level);
        }

        [Then(@"I am able to see existing previously added skills")]
        public void ThenIAmAbleToSeeExistingPreviouslyAddedSkills()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            string lastRecord = lanAndSkillPageObj.CheckFieldsSkill(driver);
            Assert.That(lastRecord != "Testing", "Record has added Cancel function is not working");
        }

        [When(@"I add multiple '([^']*)' and '([^']*)' to the Skills")]
        public void WhenIAddMultipleAndToTheSkills(string skill, string level)
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.CreateMultipleSkills(driver, skill, level);
        }

        [Then(@"I am able to see all the '([^']*)' and '([^']*)' in the list")]
        public void ThenIAmAbleToSeeAllTheAndInTheList(string skill, string level)
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.VerifySkillsListHaveNotChanged(driver, skill, level);
        }

        [When(@"I click add new to enter Language and Level contain special characters")]
        public void WhenIClickAddNewToEnterLanguageAndLevelContainSpecialCharacters()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.AddSpecialCharactersLanguage(driver);
        }

        [Then(@"I am able to see existing previously added special character languages")]
        public void ThenIAmAbleToSeeExistingPreviouslyAddedSpecialCharacterLanguages()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();

            string NewLanguage = lanAndSkillPageObj.GetSpecialCharacterLanguage(driver);
            Assert.That(lanAndSkillPageObj.GetSpecialCharacterLanguage(driver) == "Ngr3@3Fr$#et12");
        }

        [When(@"I add same '([^']*)' and '([^']*)' to the Languages")]
        public void WhenIAddSameAndToTheLanguages(string language, string level)
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.AddSameLanguage(driver, language, level);
        }

        [Then(@"I am not able to see prevoisly added language in the list")]
        public void ThenIAmNotAbleToSeePrevoislyAddedLanguageInTheList()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();

            string NewLanguage = lanAndSkillPageObj.GetLanguage(driver);
            Assert.That(lanAndSkillPageObj.GetLanguage(driver) == "Italian");
        }
    }
}
