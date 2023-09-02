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
