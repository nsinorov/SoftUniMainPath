You are at the shooting gallery again, and you need a program that helps you keep track of moving targets. On the first line, you will receive a sequence of targets with their integer values, split by a single space. Then, you will start receiving commands for manipulating the targets until the "End" command. The commands are the following:

->	"Shoot {index} {power}"

	Shoot the target at the index if it exists by reducing its value by the given power (integer value). 
	Remove the target if it is shot. A target is considered shot when its value reaches 0.

->	"Add {index} {value}"

         Insert a target with the received value at the received index if it exists. 
         If not, print: "Invalid placement!"

->	"Strike {index} {radius}"

         Remove the target at the given index and the ones before and after it depending on the radius.
         If any of the indices in the range is invalid, print: "Strike missed!" and skip this command.

 Example: 
 
 ![Capture](https://user-images.githubusercontent.com/45227327/197363553-1f7f00c4-f1d3-4b7e-9ed4-f80d40c92b9f.PNG)


->       "End"

	Print the sequence with targets in the following format and end the program:
        "{target1}|{target2}…|{targetn}"

## Input:

	On the first line, you will receive the sequence of targets – integer values [1-10000].
	On the following lines, until the "End" will be receiving the command described above – strings.
	There will never be a case when the "Strike" command would empty the whole sequence.
	
## Output:

	Print the appropriate message in case of any command if necessary.
	In the end, print the sequence of targets in the format described above


![Capture](https://user-images.githubusercontent.com/45227327/197363621-153412a7-2e7a-49f9-a48d-0d7e35b9bc88.PNG)

