Write a program that keeps track of the shoes in a shoe store.

### Class Shoe

You are given a class Shoe,  create the following properties:

	Brand – string
	Type – string
	Size – double
	Material – string

The class constructor should receive brand, type, size and material. 

Override ToString() method: "Size {Size}, {Material} {Brand} {Type} shoe."

### Class ShoeStore

Next, you are given a class named ShoeStore, which has a collection of type Shoe. The name of the collection should be Shoes, which could not be modified directly. All the entities of the shoe collection have the same properties.  The ShoeStore also should have the following properties:

	Name – string
	StorageCapacity – int
	Shoes – List<Shoe>
	
The constructor of the ShoeStore class should receive name and storageCapacity. It should initialize also the Shoes with a new instance of the collection.

Implement the following features:

	Getter Count - returns the total count of the shoes in the storage room.
	
	string AddShoe(Shoe shoe) –  adds a Shoe to the Shoes collection and returns: "Successfully added {shoeType} {shoeMaterial} pair of shoes to the store." 
			If the StorageCapacity doesn’t allow adding more shoes in the Store 
			(Shoes.Count == StorageCapacity), returns: "No more space in the storage room." 

	int RemoveShoes(string material) – removes all shoes by a given material, as a result, return the count of the shoes which were removed.
	
	List<Shoe> GetShoesByType(string type) – searches and returns a list of shoes by given type. Search should be case insensitive.
	
	Shoe GetShoeBySize(double size) – return the first shoe, with the given size.
