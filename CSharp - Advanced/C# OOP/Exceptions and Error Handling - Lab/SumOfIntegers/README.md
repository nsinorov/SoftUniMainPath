You will receive a sequence of elements of different types, separated by space. Your task is to calculate the sum of all valid integer numbers in the input. Try to add each element of the array to the sum and write messages for the possible exceptions while processing the element:

	If you receive an element, which is not in the correct format (FormatException):
  
    "The element '{element}' is in wrong format!"

	If you receive an element, which is out of the integer type range (OverflowException):
  
    "The element '{element}' is out of range!"

After each processed element add the following message:

	"Element '{element}' processed - current sum: {sum}"

At the end print the total sum of all integers:

	"The total sum of all integers is: {sum}"
