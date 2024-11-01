﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BuildSmarter.Specs
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ManageMultipleBuildingsFeature : object, Xunit.IClassFixture<ManageMultipleBuildingsFeature.FixtureData>, Xunit.IAsyncLifetime
    {
        
        private static global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ManageMultipleBuildings.feature"
#line hidden
        
        public ManageMultipleBuildingsFeature(ManageMultipleBuildingsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
        }
        
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly();
            global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "Manage Multiple Buildings", ("As a building administrator\r\nI want to manage multiple buildings\r\nSo that I can k" +
                    "eep track of different buildings and their structures"), global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
            await testRunner.OnFeatureStartAsync(featureInfo);
        }
        
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
            await testRunner.OnFeatureEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
            testRunner = null;
        }
        
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
        }
        
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        async System.Threading.Tasks.Task Xunit.IAsyncLifetime.InitializeAsync()
        {
            await this.TestInitializeAsync();
        }
        
        async System.Threading.Tasks.Task Xunit.IAsyncLifetime.DisposeAsync()
        {
            await this.TestTearDownAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Adding multiple buildings")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Multiple Buildings")]
        [Xunit.TraitAttribute("Description", "Adding multiple buildings")]
        public async System.Threading.Tasks.Task AddingMultipleBuildings()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Adding multiple buildings", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 7
        await testRunner.GivenAsync("a building named \"Empire State Building\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 8
        await testRunner.AndAsync("a building named \"Chrysler Building\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 9
        await testRunner.WhenAsync("I add a floor with number 1 to \"Empire State Building\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 10
        await testRunner.AndAsync("I add a floor with number 2 to \"Chrysler Building\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 11
        await testRunner.ThenAsync("\"Empire State Building\" should have 1 floor with number 1", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 12
        await testRunner.AndAsync("\"Chrysler Building\" should have 1 floor with number 2", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Retrieving a building by name")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Multiple Buildings")]
        [Xunit.TraitAttribute("Description", "Retrieving a building by name")]
        public async System.Threading.Tasks.Task RetrievingABuildingByName()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Retrieving a building by name", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 15
        await testRunner.GivenAsync("a building named \"Empire State Building\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 16
        await testRunner.AndAsync("a building named \"Chrysler Building\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 17
        await testRunner.WhenAsync("I retrieve the building named \"Empire State Building\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 18
        await testRunner.ThenAsync("the building should be \"Empire State Building\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Deleting a building")]
        [Xunit.TraitAttribute("FeatureTitle", "Manage Multiple Buildings")]
        [Xunit.TraitAttribute("Description", "Deleting a building")]
        public async System.Threading.Tasks.Task DeletingABuilding()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Deleting a building", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 20
    this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 21
        await testRunner.GivenAsync("a building named \"Empire State Building\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 22
        await testRunner.AndAsync("a building named \"Chrysler Building\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 23
        await testRunner.WhenAsync("I delete the building named \"Empire State Building\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 24
        await testRunner.ThenAsync("the building named \"Empire State Building\" should not exist", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 25
        await testRunner.AndAsync("the building named \"Chrysler Building\" should exist", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : object, Xunit.IAsyncLifetime
        {
            
            async System.Threading.Tasks.Task Xunit.IAsyncLifetime.InitializeAsync()
            {
                await ManageMultipleBuildingsFeature.FeatureSetupAsync();
            }
            
            async System.Threading.Tasks.Task Xunit.IAsyncLifetime.DisposeAsync()
            {
                await ManageMultipleBuildingsFeature.FeatureTearDownAsync();
            }
        }
    }
}
#pragma warning restore
#endregion
