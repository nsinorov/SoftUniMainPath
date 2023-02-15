The force users are struggling to remember which side is the different forceUsers from, because they switch them too often. So you are tasked to create a web application to manage their profiles. You should store an information for every unique forceUser, registered in the application.
You will receive several input lines in one of the following formats:

    {forceSide} | {forceUser}
    {forceUser} -> {forceSide}

The forceUser and forceSide are strings, containing any character. 

If you receive forceSide | forceUser, you should check if such forceUser already exists, and if not, add him/her to the corresponding side. 

If you receive a forceUser -> forceSide, you should check if there is such a forceUser already and if so, change his/her side. If there is no such forceUser, add him/her to the corresponding forceSide, treating the command as a newly registered forceUser.

Then you should print on the console: "{forceUser} joins the {forceSide} side!".
