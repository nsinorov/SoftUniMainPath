Now we will take a look at a Façade example implementation.

We will start off by creating a class to work with:

We have the info part and the address part of our object, so we are going to use two builders to create this whole object.

We instantiate the Car object, which we want to build and expose it through the Build method.

What we need now is to create concrete builders. So, let’s start with the CarInfoBuilder which needs to inherit from the facade class:
