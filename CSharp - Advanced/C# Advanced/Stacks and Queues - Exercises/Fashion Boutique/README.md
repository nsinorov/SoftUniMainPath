You own a fashion boutique and you receive a delivery once a month in a huge box, which is full of clothes. You have to arrange them in your store, so you take the box and start from the last piece of clothing on the top of the pile to the first one at the bottom.

Use a **stack** for this purpose. Each piece of clothing has its value (an integer). You have to sum their values, while you take them out of the box. You will be given an integer, representing the capacity of a rack. 

While the sum of the clothes is less than the capacity, keep summing them. If the sum becomes equal to the capacity, you have to take a new rack for the next clothes if there are any left in the box. 

If it becomes greater than the capacity, don't add the piece of clothing to the current rack and take a new one. In the end, print how many racks you have used to hang all of the clothes.

## Input:

	On the first line, you will be given a sequence of integers, representing the clothes in the box, separated by a single space.
	On the second line, you will be given an integer, representing the capacity of a rack.

## Output:

	Print the number of racks, needed to hang all of the clothes from the box.

## Examples:

![image](https://user-images.githubusercontent.com/45227327/212744972-0c802075-109f-4c6a-9b57-88ed33b29157.png)
![image](https://user-images.githubusercontent.com/45227327/212745087-464bbb25-6ba5-491c-a05e-fe681ecf919b.png)
