We are going to create a simple console application in which we are going to read all the data from a file (which consists of cities with their population) and then use that data.

After that, we have to create a class to implement the ISingletonContainer interface. We are going to call it SingletonDataContainer

So, we have a dictionary in which we store the capital names and their population from our file. As we can see, we are reading from a file in our constructor. And that is all good.

Now we are ready to use this class in any consumer by simply instantiating it. But is this really what we need to do, to instantiate the class which reads from a file that never changes (in this particular project. the Population of the cities is changing daily). Of course not, so using a Singleton pattern would be very useful here. Let’s implement it

First, we will hide the constructor from the consumer classes by making it private. Then, we’ve created a single instance of our class and exposed it through the Instance property.

![image](https://user-images.githubusercontent.com/45227327/229227539-47b562f7-c47b-4067-a57d-07d746554cb4.png)
