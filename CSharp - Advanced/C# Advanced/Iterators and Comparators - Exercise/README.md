using System;

namespace ListyIterator
{
	
  public class ListyIterator<T>
 {
	 private int index;
	 private List<T> items;
	 
	 public ListyIterator(List<T> items)
	 { 
        this.items = new List<T>();	 
	 }
	 
	 public bool Move()
	 { 
		if(index < items.Count - 1)
		{ 
			index++;
			return true;
		}
		
		return false;
		
	 }
	 
	 public bool HasNext()
	 { 
	 return false;
	 }
	 
	 public void Print()
	 { 
		if(items.Count == 0)
		{
			throw new InvalidOperationException("Invalid Operation!);
		}
		
		Console.WriteLine(items[index])
	 }
 }	
 
}


using System;
using System.Collections.Generic;
using System.Linq;

List<string> items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();


