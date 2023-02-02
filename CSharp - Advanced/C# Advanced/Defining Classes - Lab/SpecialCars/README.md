This is the final and most interesting problem in this lab. Until you receive the command "No more tires", you will be given tire info in the format:

       {year} {pressure}
       {year} {pressure}
        …
        "No more tires"

You have to collect all the tires provided. Next, until you receive the command "Engines done" you will be given engine info and you also have to collect all that info:

       {horsePower} {cubicCapacity} 
       {horsePower} {cubicCapacity} 
       …

The final step - until you receive "Show special", you will be given information about cars in the format:
       
       {make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}
       …

Every time you have to create a new Car with the information provided. The car engine is the provided engineIndex and the tires are tiresIndex. Finally, collect all the created cars. When you receive the command "Show special", drive 20 kilometers all the cars, which were manufactured during 2017 or after, have horsepower above 330 and the sum of their tire pressure is between 9 and 10. 

Finally, print information about each special car in the following format:

       "Make: {specialCar.Make}"
       "Model: {specialCar.Model}"
       "Year: {specialCar.Year}"
       "HorsePowers: {specialCar.Engine.HorsePower}"
       "FuelQuantity: {specialCar.FuelQuantity}"

![image](https://user-images.githubusercontent.com/45227327/216331350-8b987ab6-5a71-42a4-ac9d-34b646afa0c7.png)
![image](https://user-images.githubusercontent.com/45227327/216331465-50ac5174-0774-42fa-aa9c-f8e546457745.png)
