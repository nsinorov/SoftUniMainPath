Create a program that helps you decide what clothes to wear from your wardrobe. You will receive the clothes, which are currently in your wardrobe, sorted by their color in the following format:

     "{color} -> {item1},{item2},{item3}…"

If you receive a certain color, which already exists in your wardrobe, just add the clothes to its records. You can also receive repeating items for a certain color and you have to keep their count.

In the end, you will receive a color and a piece of clothing, which you will look for in the wardrobe, separated by a space in the following format:

     "{color} {clothing}"

Your task is to print all the items and their count for each color in the following format: 

     "{color} clothes:
     * {item1} - {count}
     * {item2} - {count}
     * {item3} - {count}
       …
     * {itemN} - {count}"

If you find the item you are looking for, you need to print "(found!)" next to it:

    "* {itemN} - {count} (found!)"

