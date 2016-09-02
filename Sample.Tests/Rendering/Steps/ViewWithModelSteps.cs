﻿using System.Drawing;
using ASP;
using NUnit.Framework;
using Sample.Tests.Rendering.Shared;
using TechTalk.SpecFlow;

namespace Sample.Tests.Rendering.Steps
{
    [Binding]
    public class ViewWithModelSteps
    {
        private readonly ViewsUnderTest viewsUnderTest;
        private readonly Point model;

        public ViewWithModelSteps(ViewsUnderTest viewsUnderTest)
        {
            this.viewsUnderTest = viewsUnderTest;
            model = new Point(15, 20);
        }

        [Given(@"I have a view and a model")]
        public void GivenIHaveAViewAndAModel()
        {
            viewsUnderTest.Instance = new _Views_ViewWithModel_cshtml();
        }

        [When(@"I use the RenderAsHtml extension with the model")]
        public void WhenIUseTheRenderAsHtmlExtensionWithTheModel()
        {
            viewsUnderTest.RenderAsHtml(model);
        }

        [Then(@"the result should display values from the model")]
        public void ThenTheResultShouldDisplayValuesFromTheModel()
        {
            Assert.That(viewsUnderTest.Document.GetElementbyId("x"), Is.Not.Null.And.Property("InnerText").EqualTo(model.X.ToString()));
            Assert.That(viewsUnderTest.Document.GetElementbyId("y"), Is.Not.Null.And.Property("InnerText").EqualTo(model.Y.ToString()));
        }

    }
}