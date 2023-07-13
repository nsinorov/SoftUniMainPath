Write a JS program that receives two points in the format [x1, y1, x2, y2] and checks if the distances between each point (x, y) and the start of the Cartesian coordinate system (0, 0) and between the points themselves is valid. A distance between two points is considered valid if it is an integer value.

    In case a distance is valid print: `{x1, y1} to {x2, y2} is valid`
    In case the distance is invalid print: `{x1, y1} to {x2, y2} is invalid`

The order of comparisons should always be first {x1, y1} to {0, 0}, then {x2, y2} to {0, 0} and finally {x1, y1} to {x2, y2}. 

The input consists of two points given as an array of numbers
