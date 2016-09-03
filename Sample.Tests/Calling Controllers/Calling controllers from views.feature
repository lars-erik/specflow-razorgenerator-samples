Feature: Calling controllers from views
	In order to test views that call controllers
	I want to do as little plumbing as possible

Scenario: Call a controller from a view
	Given I have a view that calls a controller
    And I have registered the controller with ControllersUnderTest
    And I have registered the partial with ViewsUnderTest
	When I use the RenderAsHtml extension
	Then the result should include HTML from the controller action
