Feature: Feature2

Test the What's New Module in Luma application
@What'snew
Scenario: Test the What's New module
	Given click on the what's new button
	When click on orders and returns
	And provide the order id
	And provide the billing last name
	And click on find order by dropdown
	And select the email option
	And provide the email on email text box
	Then click on continue button

@Writeforus
Scenario: Test the Write for us component
	Given click on the write for us component
	When provide the text data on first name text box
	Given provide the text data on last name text box
	And write the email on email text field
	And click on verify email button
	And provide the link in website text box
	And click on the upload your article choose file button
	And select the file path
	And click on the upload featured image choose file button
	And provide text data on author bio text box
	And click on upload an author bio choose file button
	And select the file path
	And provide the text data on tags or labels text field
	Then click on submit button