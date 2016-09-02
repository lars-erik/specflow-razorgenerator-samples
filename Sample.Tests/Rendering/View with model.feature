Feature: View with model
	In order to test a view with a model
	I want to pass a model when I render it

Scenario: Render view with model
	Given I have a view and a model
	When I use the RenderAsHtml extension with the model
	Then the result should display values from the model
