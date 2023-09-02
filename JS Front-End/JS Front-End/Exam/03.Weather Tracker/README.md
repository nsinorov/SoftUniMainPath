![image](https://github.com/nsinorov/SoftUniMainPath/assets/45227327/a1e5dc60-00a1-4651-858f-f4f0450c8b6a)

### Requirements:

Write a JS program that can load, create, remove and edit a list of scheduled vacations. You will be given an HTML template to which you must bind the needed functionality.

First, you need to install all dependencies using the npm install command

Then, you can start the front-end application with the npm start command

You also must start the server.js file in the server folder using the node server.js command in another console (BOTH THE CLIENT AND THE SERVER MUST RUN AT THE SAME TIME).

At any point, you can open up another console and run npm test to test the current state of your application. It’s preferable for all of your tests to pass locally before you submit to the Judge platform, like this:

![image](https://github.com/nsinorov/SoftUniMainPath/assets/45227327/d56f7472-7008-48c5-8e87-b9780f3f3544)

### Endpoints:

    	http://localhost:3030/jsonstore/tasks/
    	http://localhost:3030/jsonstore/tasks/:id

### Load History:

![image](https://github.com/nsinorov/SoftUniMainPath/assets/45227327/ec126cfa-7507-4ccf-8ef9-4ccc69a065fd)

Clicking the [Load History] button should send a GET request to the server to fetch all records from your local database. You must add each task to the <div> with id="list". [Edit Weather] button should be deactivated.

Each record has the following HTML structure:

![image](https://github.com/nsinorov/SoftUniMainPath/assets/45227327/e367f5fd-eab6-4c38-b83c-331a61af74f1)


![image](https://github.com/nsinorov/SoftUniMainPath/assets/45227327/b07611af-6ab2-49fd-9574-4ceb7ac726e8)

### Add а Weather:

Clicking the [Add Weather] button should send a POST request to the server, creating a new scheduled vacation with the location, temperature, and date from the input values. After a successful creation, you should send another GET request to fetch all the scheduled vacations, including the newly added one into the History column. You should also clear all the input fields after the creation!

![image](https://github.com/nsinorov/SoftUniMainPath/assets/45227327/7b6029c2-d251-48d6-8a83-75f1965348e2)

### Edit a Weather:

Clicking the [Change] button on a record should remove the record from the DOM structure and the information about the task should be populated into the input fields above. The [Edit Weather] button in the form should be activated and the [Add Weather] one should be deactivated.

After clicking the [Edit Weather] button in the form, you should send a PUT request to the server to modify the location, temperature and the date of the changed item. After the successful request, you should fetch the items again and see that the changes have been made. After that, the [Edit Weather] button should be deactivated and the [Add Weather] one should be activated.

![image](https://github.com/nsinorov/SoftUniMainPath/assets/45227327/24467056-06fb-4f93-8e32-69419cbc5cba)

### Delete:

Clicking the [Delete] button should send a DELETE request to the server and remove the item from your local database. After you've removed it successfully, fetch the items again.

### Submitting Your Solution:

Select the content of your working folder (the given resources). Exclude the node_modules & tests folders. Archive the rest into a ZIP file and upload the archive to Judge.
