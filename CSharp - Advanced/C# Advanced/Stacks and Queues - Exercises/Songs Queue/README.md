Write a program that keeps track of a song's queue. The first song that is put in the queue, should be the first that gets played. A song cannot be added, if it is currently in the queue.

You will be given a sequence of songs, separated by a comma and a single space. After that, you will be given commands until there are no songs enqueued. When there are no more songs in the queue print "No more songs!" and stop the program.

The possible commands are:

	"Play" - plays a song (removes it from the queue)
	"Add {song}" - adds the song to the queue, if it isn't contained already, otherwise print "{song} is already contained!"
	"Show" - prints all songs in the queue, separated by a comma and a white space (start from the first song in the queue to the last)

## Input: 

	On the first line, you will be given a sequence of strings, separated by a comma and a white space.
	On the next lines, you will be given commands until there are no songs in the queue.

## Output:

	While receiving the commands, print the proper messages described above
	After the command "Show", print the songs from the first to the last.

## Examples:

![image](https://user-images.githubusercontent.com/45227327/212543857-f73ca054-547a-4601-bb92-0d79f1749762.png)
