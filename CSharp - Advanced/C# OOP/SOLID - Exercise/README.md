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
