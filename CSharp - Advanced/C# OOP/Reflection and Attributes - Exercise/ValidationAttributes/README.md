Create your custom validation attributes. There is a written logic inside the provided skeleton, which you can use to test the logic of your program. It is commented, so when you write the logic of your program, you can uncomment the code and test it.

### Create Attributes

Create a validation attribute: MyValidationAttribute. Its purpose is to validate properties. 

	It should contain the following method: public abstract bool IsValid(object obj)

Create a validation attribute: MyRangeAttribute.

	Its constructor should accept two parameters - int minValue, int maxValue, which represent a range of integer numbers
	It should contain two fields: int minValue and int maxValue
	It should implement the bool IsValid(object obj) method and its logic should validate whether the passed object obj parameter is within the set range

Create a validation attribute: MyRequiredAttribute.

	It should implement the bool IsValid(object obj) method and its logic should validate whether a property has the attribute or not
