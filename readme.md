### Overview

This repository shows how to test ASP.NET MVC views and controllers with [SpecFlow](http://specflow.org) 
and [Behavior Driven Development](https://en.wikipedia.org/wiki/Behavior-driven_development).
Views are rendered to [HtmlAgilityPack](https://htmlagilitypack.codeplex.com/) documents
using [RazorGenerator](https://github.com/RazorGenerator/RazorGenerator). 
The latter is currently using [my fork](https://github.com/lars-erik/RazorGenerator) to be available to render views from views.
Documentation is finally generated using Nunit.MsBuild and Pickle.

The executable specifications for this project can be viewed [here](). 

### Classes of note

These are found under Sample.Tests/[Feature]/Shared

- `ViewsUnderTest`  
  - Is injected into step bindings 
  - Initializes `HttpContextBase`
  - Set `viewsUnderTest.Instance` to the main view to render.
  - Call `viewsUnderTests.Add[Partial]<ViewType>(path)` to register views
  - Call `viewsUnderTest.RenderAsHtml([model])` to get a rendered document
- `ViewsUnderTestSteps`  
  - Sets up the view engines in `[BeforeScenario(Order=0)]` 
  - Includes the binding `I use the RenderAsHtml extension`
- `ViewsUnderTestViewEngine`
  - Registry of view types for current scenario
- `ControllersUnderTest`  
  - Is injected into step bindings
  - Call `controllersUnderTest.Add(controllerName, () => new YourController(x, y, z))` to register controllers
- `ControllersUnderTestSteps`
  - Sets `ControllersUnderTestFactory` as `ControllerBuilder`'s factory in `[BeforeScenario(Order=0)]`
- `ControllersUnderTestFactory`
  - Registry of controller factory methods for current scenario
