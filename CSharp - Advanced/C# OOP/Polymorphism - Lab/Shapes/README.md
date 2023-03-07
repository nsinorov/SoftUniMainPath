NOTE: You need a public StartUp class with the namespace Shapes.

Create a class hierarchy, starting with abstract class Shape:

	Abstract methods:

	CalculatePerimeter(): double
	CalculateArea(): double

	Virtual methods:

	Draw(): string

	The method should get the name of class type as string, and should return a message in the format: $"Drawing {classType.Name}"

Extend the Shape class with two children:

	Rectangle
	Circle

Each of them needs to have: 

	Fields: 
		height and width for Rectangle
		radius for Circle
		
	Encapsulation for these fields
	A public constructor 
	Concrete methods for calculations (perimeter and area)
	Override methods for drawing 

### Example

![image](https://user-images.githubusercontent.com/45227327/223538998-d7f29ad0-70cd-4841-94ae-aa48aeb3d558.png)
