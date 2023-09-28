Feature: Feature1
Test the Luma application

@mytag1
Scenario: Test the Men module
	Given click on "men" dropdown
	When click on jackets
	And click on style dropdown
	And click on soft shell
	And click on size dropdown
	And select M size
	And click on colors dropdown
	And select blue color
	And click on add to cart in third column that is lando gym jacket
	And provide the mail address in email text box
	Then click on subscribe button

	@mytag2
	Scenario: Test the women module
	Given click on women dropdown module
	When click on hoodies and sweatshirts
	And clcik on style dropdown
	And select the full zip option
	And click on material dropdown
	And select the cotton option
	And click on position dropdown
	And select the product name
	And click on email text box
	Then provide the username on text email box

	@mytag3
	Scenario: Test the Gear module
	Given click on gear module
	When click on bags component
	And click on acticity dropdown
	And click on gyp component
	And click on driven backpack
	And click on quantity
	And enter the data as 2 number
	Then click on add to cart
