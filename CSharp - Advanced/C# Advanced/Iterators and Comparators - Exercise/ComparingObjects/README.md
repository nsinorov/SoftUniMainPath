Create a class Person. Each person should have a name, an age and a town. You should implement the interface – IComparable<T> and implement the CompareTo method.
When you compare two people, first you should compare their names, after that – their age and finally – their towns. You will be receiving input with information about the people until you receive the "END" command in the following format:
  
     "{name} {age} {town}"
  
After that, you will receive n – the n'th person from your collection, starting from 1. You should keep statistics how many people are equal to him, how many people are not equal to him, and the total people in your collection in the following format:
  
     "{count of matches} {number of not equal people} {total number of people}"
  
If there are no equal people print:
  
    "No matches".
