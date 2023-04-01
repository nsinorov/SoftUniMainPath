Your task is to create a console application that calculates the total price of gifts that are being sold in a shop. The gift could be a single element (toy) or it can be a complex gift that consists of a box with two toys and another box with maybe one toy and the box with a single toy inside. We have a tree structure representing our complex gift so, implementing the Composite design pattern will be the right solution for us.

### 1.	Component

First, you have to create an abstract class to represent the base gift. It should have two fields (name and price) and a method that calculates the total price. These fields and methods are going to be used as an interface between the Leaf and the Composite part of our pattern.

### Basic Operations

Create an interface IGiftOperations that will contain two operations - Add and Remove (a gift). You should create the interface because the Leaf class doesn’t need the operation methods.

### 2.	Composite Class

Now you have to create the composite class (CompositeGift). It should inherit the GiftBase class and implement the IGiftOperations interface. Therefore, the implementation is pretty forward. It will consist of many objects from the GiftBase class. The Add method will add a gift and the Remove - will remove one. The CalculateTotalPrice method will return the price of the CompositeGift.
