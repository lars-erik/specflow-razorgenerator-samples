Feature: Views with partials
	In order to test a view including a child partial
	I want to render the parent view and get HTML including the child content

@mytag
Scenario: Render view with partial
	Given I have an instance of a view with a partial
    And I have registered the partial with ViewsUnderTest
	When I use the RenderAsHtml extension
	Then the result should be a HtmlDocument containing HTML from the partial
