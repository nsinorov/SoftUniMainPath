Create a class Person. Each person should have a name, an age and a town. You should implement the interface – IComparable<T> and implement the CompareTo method.
When you compare two people, first you should compare their names, after that – their age and finally – their towns. You will be receiving input with information about the people until you receive the "END" command in the following format:
  
     "{name} {age} {town}"
  
After that, you will receive n – the n'th person from your collection, starting from 1. You should keep statistics how many people are equal to him, how many people are not equal to him, and the total people in your collection in the following format:
  
     "{count of matches} {number of not equal people} {total number of people}"
  
If there are no equal people print:
  
    "No matches".

### Input:

	You will be receiving lines in the format described above, until the "END" command.
	After the "END" command, you will receive the position of the person you should compare the others to. 

Note: Start counting the people in your collection from 1.

### Output:

	Print a single line of output in the format described above.

### Constraints:

	Input names, ages and addresses will be valid. 
	Input number will always be а valid integer in the range [2…100].

### Examples:

![image](https://user-images.githubusercontent.com/45227327/219794924-015ced29-be32-420b-8c1e-d24758a1819e.png)
![image](https://user-images.githubusercontent.com/45227327/219795054-fc05bdbc-d2e6-46ac-a2b3-264dbb8b20e0.png)
