# 1.	Logger

Write a logging library for logging messages. The interface for the end-user should be as follows:

![image](https://user-images.githubusercontent.com/45227327/225741175-837a2036-5a81-4528-8f9e-f24042754b2e.png)

Logger logs data and time (string) and a message (string).

### Library Architecture:

The library should have the following components:

	Layouts - define the format in which messages should be appended (e.g. SimpleLayout displays logs in the format "<date-time> - <report level> - <message>")
	Appenders - responsible for appending the messages somewhere (e.g. Console, File, etc.)
    Loggers - hold methods for various kinds of logging (warnings, errors, info, etc.)

Whenever a logger is told to log something, it calls all of its appenders and tells them to append the message. In turn, the appenders append the message (e.g. to the console or a file) according to the layout they have.

### Requirements:

Your library should correctly follow all of the SOLID principles:

	Single Responsibility Principle - no class or method should do more than one thing at once
	Open-Closed Principle - the library should be open for extension (i.e. its user should be able to create his own layouts/appenders/loggers)
	Liskov Substitution Principle - children classes should not break the behavior of their parent
	Interface Segregation Principle - the library should provide simple interfaces for the client to implement
	Dependency Inversion - no class/method should directly depend on concretions (only on abstractions)

Avoid code repetition. Name everything accordingly.


The library should provide the following ready classes for the client:

	SimpleLayout - defines the format "<date-time> - <report level> - <message>"
	ConsoleAppender - appends a log to the console, using the provided layout
	FileAppender - appends a log to a file, using the provided layout
	LogFile - a custom file class, which logs messages in a string builder, using the =-Method Write(). It should have a getter for its size, which is the sum of the ASCII codes of all alphabet characters it contains (e.g. a-z and A-Z)
	Logger - a logger class, which is used to log messages. Calls each of its appenders when something needs to be logged

![image](https://user-images.githubusercontent.com/45227327/225741768-f755e31e-9e73-4e54-8505-fbd47a1457c4.png)

The above code should log the messages both on the console and in log.txt in the format SimpleLayout provides.

### Extensibility

The end-user should be able to add his own layouts/appenders/loggers and use them. For example, he should be able to create his XmlLayout and make the appenders use it, without directly editing the library source code.

![image](https://user-images.githubusercontent.com/45227327/225741883-67370762-1669-4387-b10c-048a9dbeaa3a.png)

### Report Threshold

Implement a report level threshold in all appenders. The appender should append only messages with report level above or equal to its report level threshold (by default all messages are appended). The report level is in the order Info > Warning > Error > Critical > Fatal.

![image](https://user-images.githubusercontent.com/45227327/225741998-95fd9fa4-28c0-4be9-a2ba-81be466aa09d.png)

### LogFile

A file should write all messages internally and it should keep information about its size.

The size of a file is calculated by summing ASCII codes of all alphabet characters (a-Z). For example, a file appender with a simple layout and a single message "3/31/2015 5:33:07 PM - ERROR - Error parsing request" has size 2606 (including all characters in PM, ERROR, Error, parsing, request). In the case of XML layout, the file would have size 6632, because of the extra characters within the tags.

### Command Interpreter

Implement a Command Interpreter, which reads all appenders that a Logger will have and input messages from the console. Every message should be evaluated by all the appenders and logged if they meet the report level. Console appenders should write directly on the console. File appenders write (save) the messages, but do not print them.

### Input

On the first line, you will get N - the number of appenders. On the next N lines, you will get information about the appenders in one of the formats below: 

	"<appender type> <layout type> <REPORT LEVEL>"
	"<appender type> <layout type>"

If no report level is provided, the appender should be set to record all messages.

Next, until you get the "END" command you will receive messages containing report level, time, and message separated by pipe "|":

	"<REPORT LEVEL>|<time>|<message>"

### Output

Console appenders should print directly at the console in the layout they are provided:

	Simple layout example - "3/31/2015 5:33:07 PM - ERROR - Error parsing request"
	Xml layout example (date, level, and message tags are indented by 1 tabulation):

	<log>
	    <date>3/31/2015 5:33:07 PM</date>
	    <level>ERROR</level>
	    <message>Error parsing request</message>
	</log>

After the "END" command, you should print Logger info, which includes statistics about every appender (its type, layout, report level, messages appended, and file size for file appenders):

	"Logger info
	Appender type: <appender type>, Layout type: <layout type>, Report level: <REPORT LEVEL>, Messages appended: <count>, File size <size>"

### Examples:

![image](https://user-images.githubusercontent.com/45227327/225742567-e48bd870-dc1d-4ba9-be6e-1cacdeb7a219.png)