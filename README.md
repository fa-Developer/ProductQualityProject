# ProductQualityProject
this is ProductQualityProject refactoring kata in  CSharpCore using NUnit testing framework and the Abstract Factory Pattern.
the ProductQualityProject is an application that allows the update of Quality and SellIn properties for all type of products of a company.
First an introduction to our system:

	- All items have a SellIn value which denotes the number of days we have to sell the item
	- All items have a Quality value which denotes how valuable the item is
	- At the end of each day our system lowers both values for every item

Pretty simple, right? Well this is where it gets interesting:

	- Once the sell by date has passed, Quality degrades twice as fast
	- The Quality of an item is never negative
	- "Aged Brie" actually increases in Quality the older it gets
	- The Quality of an item is never more than 50
	- "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
	- "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
	Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
	Quality drops to 0 after the concert

We have recently signed a supplier of conjured items. This requires an update to our system:

	- "Conjured" items degrade in Quality twice as fast as normal items
# Important Note
there many tests cases in this application for each product type.

To run the application in Visual Studio you can select Debug > Start without debugging from the top menu of Visual Studio.

To run the tests choose Test > Test Explorer from the top menu bar of Visual Studio and then run your unit tests by clicking Run All .
