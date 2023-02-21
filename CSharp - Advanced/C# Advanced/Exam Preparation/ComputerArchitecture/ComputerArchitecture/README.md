Your task is to create a computer repository that stores CPU components by creating the classes described below.

### Class CPU (Central Processing Unit)

You are given a class CPU,  create the following properties:

	Brand - string
	Cores - int
	Frequency - double

The class constructor should receive brand, cores, and frequency.

Override the ToString() method in the following format:

    "{brand} CPU:
      Cores: {cores}
     Frequency: {frequency} GHz"

Note: Format the Frequency to the first digit after the decimal point!

### Class Computer

Next, you are given a class Computer that has a Multiprocessor (a collection that stores CPU entities). All entities inside the collection have the same fields. Every Computer will have Capacity of the motherboard, and adding new CPU will be limited by the Capacity. Also, the Computer class should have the following properties:

	Model - string
	Capacity – int 
	Multiprocessor – List<CPU>

The class constructor should receive the model and capacity, also it should initialize the multiprocessor with a new instance of the collection.

Implement the following features:

	Getter Count - returns the number of CPUs
	
	Method	 Add(CPU cpu) - adds an entity to the multiprocessor if there is room for it. If there is no room for another CPU, skip the command
