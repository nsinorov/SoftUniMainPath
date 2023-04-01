Your task is to create a console application that calculates the total price of gifts that are being sold in a shop. The gift could be a single element (toy) or it can be a complex gift that consists of a box with two toys and another box with maybe one toy and the box with a single toy inside. We have a tree structure representing our complex gift so, implementing the Composite design pattern will be the right solution for us.

### 1.	Component

First, you have to create an abstract class to represent the base gift. It should have two fields (name and price) and a method that calculates the total price. These fields and methods are going to be used as an interface between the Leaf and the Composite part of our pattern.

### Basic Operations

Create an interface IGiftOperations that will contain two operations - Add and Remove (a gift). You should create the interface because the Leaf class doesn’t need the operation methods.

### 2.	Composite Class

Now you have to create the composite class (CompositeGift). It should inherit the GiftBase class and implement the IGiftOperations interface. Therefore, the implementation is pretty forward. It will consist of many objects from the GiftBase class. The Add method will add a gift and the Remove - will remove one. The CalculateTotalPrice method will return the price of the CompositeGift.

### 3.	Leaf Class

You should also create a Leaf class (SingleGift). It will not have sub-levels so it doesn’t require to add and delete operations. Therefore, it should only inherit the GiftBase class. It will be like a single gift, without component gifts.

### Use What You’ve Done

Now is the time to test what you have done by trying to use it. In your Main() method you can do just that by instantiating the Leaf class (SingleGift) and the Composite class (CompositeGift) and using their methods.

![image](https://user-images.githubusercontent.com/45227327/229312335-05241c17-53a6-4c6a-ae95-8a4e60540d72.png)

![image](https://user-images.githubusercontent.com/45227327/229312352-5e2e2649-1470-4cd6-875c-cfb19bb7f84a.png)
