Write a program that receives a total of 4 parameters in the format x1, y1, x2, y2. Check if the distance between each point (x, y) and the beginning of the Cartesian coordinate system (0, 0) is valid. A distance between two points is considered valid if it is an integer value. 

Note: You can use the following formula to help you calculate the distance between the points (x1, y1) and (x2, y2).

![image](https://github.com/nsinorov/SoftUniMainPath/assets/45227327/af08fe20-5919-4da8-9b7b-fe9d28b1d53d)

The order of comparisons should always be first {x1, y1} to {0, 0}, then {x2, y2} to {0, 0} and finally {x1, y1} to {x2, y2}.

In case a distance is valid, print: `{x1, y1} to {x2, y2} is valid`
If the distance is invalid, print: `{x1, y1} to {x2, y2} is invalid`

The input consists of two points given as 4 numbers.

For each comparison print either `{x1, y1} to {x2, y2} is valid` if the distance is valid, or `{x1, y1} to {x2, y2} is invalid` if it is invalid.

### Examples:

