You are given a library with the following classes:

	Worker implements ISleeper
	Employee inherits Worker
 	Robot inherits Worker
	RechargeStation

If you inspect the code, you can see that some of the classes have methods that they can't use (throw UnsupportedOpperationException), which is a clear indication that the code should be refactored.

Refactor the structure, so that it conforms to the Interface Segregation Principle.

### Hints:

Make the Robot extend Worker and at the same time implement Rechargeable.

![image](https://user-images.githubusercontent.com/45227327/225396568-7222b1b5-b960-4383-b211-9cdef7fa14c5.png)
