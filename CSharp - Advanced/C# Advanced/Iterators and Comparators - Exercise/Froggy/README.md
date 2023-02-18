Let's play a game. You have a tiny little Frog and a Lake that has a path of stones in it. Every stone has a number. Our frog must cross the lake along that path and then return. But there are some rules. First, the frog must jump on all the stones, which are in even positions in ascending order, and then on all the odd ones, but in reversed order.

The order of the stones and their numbers will be given on the first line of input. Then you must print the order of stones in which our frog jumped from one to another.

![image](https://user-images.githubusercontent.com/45227327/219899473-3f28adc5-9ccd-4009-9f7f-403bf1e43daa.png)

Try to achieve this functionality by creating a class Lake (it will hold all stone numbers in order) that implements the IEnumerable<int> interface and overrides its GetEnumerator() methods.

  ### Examples:
  
  ![image](https://user-images.githubusercontent.com/45227327/219899489-e77a020a-5569-4924-b592-f59074ac1ae6.png)
