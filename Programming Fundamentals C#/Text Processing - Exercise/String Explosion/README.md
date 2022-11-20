Explosions are marked with '>'. Immediately after the mark, there will be an integer, which signifies the strength of the explosion.

You should remove x characters (where x is the strength of the explosion), starting after the punched character ('>').

If you find another explosion mark ('>') while you're deleting characters, you should add the strength to your previous explosion.

When all characters are processed, print the string without the deleted characters. 

You should not delete the explosion character – '>', but you should delete the integers, which represent the strength. 

## Input

You will receive a single line with the string.

## Output

Print what is left from the string after the explosions.

