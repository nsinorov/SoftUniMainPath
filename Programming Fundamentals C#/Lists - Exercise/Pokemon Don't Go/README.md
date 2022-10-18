You will receive a sequence of integers, separated by spaces – the distances to the pokemon. Then you will begin receiving integers, which will correspond to indexes in that sequence.

When you receive an index, you must remove the element at that index from the sequence (as if you've captured the pokemon).

	You must increase the value of all elements in the sequence, which are less or equal to the removed element, with the value of the removed element.
	You must decrease the value of all elements in the sequence, which are greater than the removed element, with the value of the removed element.

If the given index is less than 0, remove the first element of the sequence, and copy the last element to its place.
If the given index is greater than the last index of the sequence, remove the last element from the sequence, and copy the first element to its place.

The increasing and decreasing of elements should be done in these cases, also. The element, whose value you should use, is the removed element.

The program ends when the sequence has no elements (there are no pokemon left for Ely to catch).

## Input

    On the first line of input you will receive a sequence of integers, separated by spaces.
    On the next several lines, you will receive integers – the indexes

## Output

    When the program ends, you must print the summed value of all removed elements.
    
   
 ![Capture](https://user-images.githubusercontent.com/45227327/196555472-9f8e728a-f20c-4c56-bbdd-0cd80b2921ba.PNG)

