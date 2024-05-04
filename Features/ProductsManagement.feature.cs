﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace LicUiTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ProductsManagement")]
    [NUnit.Framework.CategoryAttribute("ProductsManagement")]
    public partial class ProductsManagementFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "ProductsManagement"};
        
#line 1 "ProductsManagement.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "ProductsManagement", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line hidden
#line 5
 testRunner.Given("I navigate to Licenta app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.And("I navigate to Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successfully display products for admin")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public void SuccessfullyDisplayProductsForAdmin()
        {
            string[] tagsOfScenario = new string[] {
                    "SmokeTests"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully display products for admin", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table27.AddRow(new string[] {
                            "username",
                            "admin"});
                table27.AddRow(new string[] {
                            "password",
                            "Admin@123"});
#line 10
 testRunner.When("I log in with the following credentials", ((string)(null)), table27, "When ");
#line hidden
#line 14
 testRunner.Then("I\'m successfully logged into Licenta app with user A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
 testRunner.When("I navigate to \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then("all the products are displayed through the table for admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
 testRunner.And("the button Adauga produs is available for the admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successfully display products for customer")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public void SuccessfullyDisplayProductsForCustomer()
        {
            string[] tagsOfScenario = new string[] {
                    "SmokeTests"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully display products for customer", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table28.AddRow(new string[] {
                            "username",
                            "custone"});
                table28.AddRow(new string[] {
                            "password",
                            "Admin@123"});
#line 21
 testRunner.When("I log in with the following credentials", ((string)(null)), table28, "When ");
#line hidden
#line 25
 testRunner.Then("I\'m successfully logged into Licenta app with user C", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.When("I navigate to \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then("all the products are displayed through the table for customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.And("the button Adauga produs is not avaialble for the customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successfully add a new product as admin")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        [NUnit.Framework.CategoryAttribute("ProductCleanUp")]
        public void SuccessfullyAddANewProductAsAdmin()
        {
            string[] tagsOfScenario = new string[] {
                    "SmokeTests",
                    "ProductCleanUp"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully add a new product as admin", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 31
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table29.AddRow(new string[] {
                            "username",
                            "admin"});
                table29.AddRow(new string[] {
                            "password",
                            "Admin@123"});
#line 32
 testRunner.When("I log in with the following credentials", ((string)(null)), table29, "When ");
#line hidden
#line 36
 testRunner.Then("I\'m successfully logged into Licenta app with user A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 37
 testRunner.When("I navigate to \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.And("I select Adauga produs button from \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table30.AddRow(new string[] {
                            "Nume produs",
                            "Produs Test"});
                table30.AddRow(new string[] {
                            "Pret produs",
                            "250.99"});
                table30.AddRow(new string[] {
                            "Stoc disponibil",
                            "100"});
#line 39
 testRunner.And("I fill in the new product\'s details", ((string)(null)), table30, "And ");
#line hidden
#line 44
 testRunner.And("I select Adauga button from \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.Then("the following toast message is displayed: Produsul a fost adaugat cu succes!", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.And("I confirm the new product is displayed through products table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Can\'t add a new product with stock 0")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public void CantAddANewProductWithStock0()
        {
            string[] tagsOfScenario = new string[] {
                    "SmokeTests"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can\'t add a new product with stock 0", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 49
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table31.AddRow(new string[] {
                            "username",
                            "admin"});
                table31.AddRow(new string[] {
                            "password",
                            "Admin@123"});
#line 50
 testRunner.When("I log in with the following credentials", ((string)(null)), table31, "When ");
#line hidden
#line 54
 testRunner.Then("I\'m successfully logged into Licenta app with user A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 55
 testRunner.When("I navigate to \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.And("I select Adauga produs button from \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table32.AddRow(new string[] {
                            "Nume produs",
                            "Produs Test"});
                table32.AddRow(new string[] {
                            "Pret produs",
                            "250.99"});
                table32.AddRow(new string[] {
                            "Stoc disponibil",
                            "0"});
#line 57
 testRunner.And("I fill in the new product\'s details", ((string)(null)), table32, "And ");
#line hidden
#line 62
 testRunner.And("I select Adauga button from \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.Then("the following error toast message is displayed: Valoarea stocului trebuie sa fie " +
                        "mai mare decat zero.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Can\'t add a new product with negative stock")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public void CantAddANewProductWithNegativeStock()
        {
            string[] tagsOfScenario = new string[] {
                    "SmokeTests"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can\'t add a new product with negative stock", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 66
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table33.AddRow(new string[] {
                            "username",
                            "admin"});
                table33.AddRow(new string[] {
                            "password",
                            "Admin@123"});
#line 67
 testRunner.When("I log in with the following credentials", ((string)(null)), table33, "When ");
#line hidden
#line 71
 testRunner.Then("I\'m successfully logged into Licenta app with user A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 72
 testRunner.When("I navigate to \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.And("I select Adauga produs button from \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table34.AddRow(new string[] {
                            "Nume produs",
                            "Produs Test"});
                table34.AddRow(new string[] {
                            "Pret produs",
                            "250.99"});
                table34.AddRow(new string[] {
                            "Stoc disponibil",
                            "-10"});
#line 74
 testRunner.And("I fill in the new product\'s details", ((string)(null)), table34, "And ");
#line hidden
#line 79
 testRunner.And("I select Adauga button from \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
 testRunner.Then("the following error toast message is displayed: Valoarea stocului trebuie sa fie " +
                        "mai mare decat zero.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Can\'t add a new product with price 0")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public void CantAddANewProductWithPrice0()
        {
            string[] tagsOfScenario = new string[] {
                    "SmokeTests"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can\'t add a new product with price 0", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 83
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table35.AddRow(new string[] {
                            "username",
                            "admin"});
                table35.AddRow(new string[] {
                            "password",
                            "Admin@123"});
#line 84
 testRunner.When("I log in with the following credentials", ((string)(null)), table35, "When ");
#line hidden
#line 88
 testRunner.Then("I\'m successfully logged into Licenta app with user A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.When("I navigate to \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
 testRunner.And("I select Adauga produs button from \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table36.AddRow(new string[] {
                            "Nume produs",
                            "Produs Test"});
                table36.AddRow(new string[] {
                            "Pret produs",
                            "0"});
                table36.AddRow(new string[] {
                            "Stoc disponibil",
                            "100"});
#line 91
 testRunner.And("I fill in the new product\'s details", ((string)(null)), table36, "And ");
#line hidden
#line 96
 testRunner.And("I select Adauga button from \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.Then("the following error toast message is displayed: Pretul setat noului produs trebui" +
                        "e sa aiba o valoare mai mare sau egala decat 0.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Can\'t add a new product with negative price")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public void CantAddANewProductWithNegativePrice()
        {
            string[] tagsOfScenario = new string[] {
                    "SmokeTests"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Can\'t add a new product with negative price", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 100
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table37.AddRow(new string[] {
                            "username",
                            "admin"});
                table37.AddRow(new string[] {
                            "password",
                            "Admin@123"});
#line 101
 testRunner.When("I log in with the following credentials", ((string)(null)), table37, "When ");
#line hidden
#line 105
 testRunner.Then("I\'m successfully logged into Licenta app with user A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 106
 testRunner.When("I navigate to \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 107
 testRunner.And("I select Adauga produs button from \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table38.AddRow(new string[] {
                            "Nume produs",
                            "Produs Test"});
                table38.AddRow(new string[] {
                            "Pret produs",
                            "-10"});
                table38.AddRow(new string[] {
                            "Stoc disponibil",
                            "100"});
#line 108
 testRunner.And("I fill in the new product\'s details", ((string)(null)), table38, "And ");
#line hidden
#line 113
 testRunner.And("I select Adauga button from \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.Then("the following error toast message is displayed: Pretul setat noului produs trebui" +
                        "e sa aiba o valoare mai mare sau egala decat 0.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Fileds are mandatory for adding a new product")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public void FiledsAreMandatoryForAddingANewProduct()
        {
            string[] tagsOfScenario = new string[] {
                    "SmokeTests"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fileds are mandatory for adding a new product", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 117
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table39.AddRow(new string[] {
                            "username",
                            "admin"});
                table39.AddRow(new string[] {
                            "password",
                            "Admin@123"});
#line 118
 testRunner.When("I log in with the following credentials", ((string)(null)), table39, "When ");
#line hidden
#line 122
 testRunner.Then("I\'m successfully logged into Licenta app with user A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 123
 testRunner.When("I navigate to \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 124
 testRunner.And("I select Adauga produs button from \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table40 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table40.AddRow(new string[] {
                            "Nume produs",
                            ""});
                table40.AddRow(new string[] {
                            "Pret produs",
                            "15"});
                table40.AddRow(new string[] {
                            "Stoc disponibil",
                            "15"});
#line 125
 testRunner.And("I fill in the new product\'s details", ((string)(null)), table40, "And ");
#line hidden
#line 130
 testRunner.And("I select Adauga button from \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 131
 testRunner.Then("the following error message is displayed: Toate campurile sunt obligatorii.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successfully filter products by name")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public void SuccessfullyFilterProductsByName()
        {
            string[] tagsOfScenario = new string[] {
                    "SmokeTests"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully filter products by name", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 134
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table41 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table41.AddRow(new string[] {
                            "username",
                            "admin"});
                table41.AddRow(new string[] {
                            "password",
                            "Admin@123"});
#line 135
 testRunner.When("I log in with the following credentials", ((string)(null)), table41, "When ");
#line hidden
#line 139
 testRunner.Then("I\'m successfully logged into Licenta app with user A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 140
 testRunner.When("I navigate to \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 141
 testRunner.And("I filter the list of products by name: Product Demo 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 142
 testRunner.Then("I confirm the displayed product is Product Demo 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successfully order products by ascending price")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public void SuccessfullyOrderProductsByAscendingPrice()
        {
            string[] tagsOfScenario = new string[] {
                    "SmokeTests"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully order products by ascending price", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 145
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table42 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table42.AddRow(new string[] {
                            "username",
                            "admin"});
                table42.AddRow(new string[] {
                            "password",
                            "Admin@123"});
#line 146
 testRunner.When("I log in with the following credentials", ((string)(null)), table42, "When ");
#line hidden
#line 150
 testRunner.Then("I\'m successfully logged into Licenta app with user A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 151
 testRunner.When("I navigate to \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 152
 testRunner.And("I filter the list of products by ascending price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 153
 testRunner.Then("I confirm the first product\'s price is 1 RON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successfully order products by descending price")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public void SuccessfullyOrderProductsByDescendingPrice()
        {
            string[] tagsOfScenario = new string[] {
                    "SmokeTests"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully order products by descending price", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 156
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table43 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table43.AddRow(new string[] {
                            "username",
                            "admin"});
                table43.AddRow(new string[] {
                            "password",
                            "Admin@123"});
#line 157
 testRunner.When("I log in with the following credentials", ((string)(null)), table43, "When ");
#line hidden
#line 161
 testRunner.Then("I\'m successfully logged into Licenta app with user A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 162
 testRunner.When("I navigate to \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 163
 testRunner.And("I filter the list of products by descending price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 164
 testRunner.Then("I confirm the first product\'s price is 999.99 RON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("View stock for each product is available")]
        [NUnit.Framework.CategoryAttribute("SmokeTests")]
        public void ViewStockForEachProductIsAvailable()
        {
            string[] tagsOfScenario = new string[] {
                    "SmokeTests"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("View stock for each product is available", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 167
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table44 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table44.AddRow(new string[] {
                            "username",
                            "custone"});
                table44.AddRow(new string[] {
                            "password",
                            "Admin@123"});
#line 168
 testRunner.When("I log in with the following credentials", ((string)(null)), table44, "When ");
#line hidden
#line 172
 testRunner.Then("I\'m successfully logged into Licenta app with user C", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 173
 testRunner.When("I navigate to \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 174
 testRunner.And("I filter the list of products by name: Product Demo 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 175
 testRunner.And("I select Vezi stoc button from \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 176
 testRunner.Then("the stock for the selected product is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Products are displayed through pages")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public void ProductsAreDisplayedThroughPages()
        {
            string[] tagsOfScenario = new string[] {
                    "Ignore"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Products are displayed through pages", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 179
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table45 = new TechTalk.SpecFlow.Table(new string[] {
                            "key",
                            "value"});
                table45.AddRow(new string[] {
                            "username",
                            "custone"});
                table45.AddRow(new string[] {
                            "password",
                            "Admin@123"});
#line 180
 testRunner.When("I log in with the following credentials", ((string)(null)), table45, "When ");
#line hidden
#line 184
 testRunner.Then("I\'m successfully logged into Licenta app with user C", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 185
 testRunner.When("I navigate to \'Produse\' tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 186
 testRunner.Then("I confirm products are displayed through pages", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 187
 testRunner.And("I am able to change the number of results per page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
