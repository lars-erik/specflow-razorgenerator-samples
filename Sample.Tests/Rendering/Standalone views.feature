Feature: Standalone views
	In order to test a simple view
	I want to render a view instance as HTML with one method call

Scenario: Render simple view
	Given I have an instance of a simple view
	When I use the RenderAsHtml extension
	Then the result should be a HTML document
