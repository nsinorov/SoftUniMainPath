Create a command pattern design using reflection. Use the provided skeleton, which contains a public StartUp class with a written logic inside the Main method.

It is commented, so when you write the logic of your program, you can uncomment the code and test it. The input of commands will be received until the "Exit" command.

Each command line will look as it follows: "{CommandName} {CommandArgs}". CommandName will be as follows: "Hello" -> executing HelloCommand and so on.

There are a few steps you can follow to employ the command pattern design:

### Create a Command Interface

Create a Command interface - ICommand, which contains a method - Execute(string[] args). 
