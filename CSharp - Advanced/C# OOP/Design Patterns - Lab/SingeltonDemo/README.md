We are going to create a simple console application in which we are going to read all the data from a file (which consists of cities with their population) and then use that data.

After that, we have to create a class to implement the ISingletonContainer interface. We are going to call it SingletonDataContainer

So, we have a dictionary in which we store the capital names and their population from our file. As we can see, we are reading from a file in our constructor. And that is all good.

Now we are ready to use this class in any consumer by simply instantiating it. But is this really what we need to do, to instantiate the class which reads from a file that never changes (in this particular project. the Population of the cities is changing daily). Of course not, so using a Singleton pattern would be very useful here. Let’s implement it

First, we will hide the constructor from the consumer classes by making it private. Then, we’ve created a single instance of our class and exposed it through the Instance property.

![image](https://user-images.githubusercontent.com/45227327/229227539-47b562f7-c47b-4067-a57d-07d746554cb4.png)

At this point, we can call the Instance property as many times as we want, but our object is going to be instantiated only once and shared for every other call. 

The result in out console will be the following:

![image](https://user-images.githubusercontent.com/45227327/229228015-16d017cf-576c-4f57-a4a8-846d6b7913d4.png)

We can see that we are calling our instance four times but it is initialized only once, which is exactly what we want.
Let’s check if our console program works:

![image](https://user-images.githubusercontent.com/45227327/229228558-4e05d88d-4ea8-4ce3-bc22-551993772eb2.png)
