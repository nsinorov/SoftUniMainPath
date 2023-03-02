For this problem, you have to download the provided skeleton.

You should be familiar with encapsulation already. For this problem, you’ll be working with the AnimalFarm project. It contains a class Chicken. Chicken contains several fields, a constructor, several properties, and methods. Your task is to encapsulate or hide anything unintended for viewing or modification from outside the class.

### Step 1. Encapsulate Fields

Fields should be private. Leaving fields open for modification from outside the class is potentially dangerous. Make all fields in the Chicken class private. In case the value inside the field is needed elsewhere, use getters to reveal it.

### Step 2. Ensure Classes Have a Correct State

Having getters and setters is useless if you don’t use them. The Chicken constructor modifies the fields directly, which is wrong when there are suitable setters available. Modify the constructor to fix this issue.

### Step 3. Validate Data Properly

Validate the chicken’s name (it cannot be null, empty, or whitespace). In case of an invalid name, print the Exception message: "Name cannot be empty.".
