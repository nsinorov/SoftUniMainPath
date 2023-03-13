You will receive a sequence of elements of different types, separated by space. Your task is to calculate the sum of all valid integer numbers in the input. Try to add each element of the array to the sum and write messages for the possible exceptions while processing the element:

	If you receive an element, which is not in the correct format (FormatException):
  
    "The element '{element}' is in wrong format!"

	If you receive an element, which is out of the integer type range (OverflowException):
  
    "The element '{element}' is out of range!"

After each processed element add the following message:

	"Element '{element}' processed - current sum: {sum}"

At the end print the total sum of all integers:

	"The total sum of all integers is: {sum}"

### Examples:

![image](https://user-images.githubusercontent.com/45227327/224835034-937b0a74-9b13-4dd0-b5dd-20bda43e2725.png)
![image](https://user-images.githubusercontent.com/45227327/224835144-5ef553e2-4050-4238-9561-eadbcdfce816.png)
