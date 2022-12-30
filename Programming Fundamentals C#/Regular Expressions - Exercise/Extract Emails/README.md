Write a program to extract all email addresses from a given text. The text comes at the only input line. Print the emails on the console, each at a separate line. 

Emails are considered to be in format <user>@<host>, where: 
      
   * <user> is a sequence of letters and digits, where '.', '-' and '_' can appear between them
      
   - Examples of valid users: "stephan", "mike03", "s.johnson", "st_steward", "softuni-bulgaria", "12345".
   - Examples of invalid users: ''--123", "……", "nakov_-", "_steve", ".info". 
  
   *	<host> is a sequence of at least two words, separated by dots '.'. Each word is a sequence of letters and can have hyphens '-' between the letters.
      
   - Examples of hosts: "softuni.bg", "software-university.com", "intoprogramming.info", "mail.softuni.org". 
   - Examples of invalid hosts: "helloworld", ".unknown.soft.", "invalid-host-", "invalid-". 
  
  *	Examples of valid emails: info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, info-bg@software-university.software.academy. 
  
  *	Examples of invalid emails: --123@gmail.com, …@mail.bg, .info@info.info, _steve@yahoo.cn, mike@helloworld, mike@.unknown.soft., s.johnson@invalid-.

## Examples:
      
      
![image](https://user-images.githubusercontent.com/45227327/210111675-ed3e7466-d400-4813-8631-96a34684c197.png)
