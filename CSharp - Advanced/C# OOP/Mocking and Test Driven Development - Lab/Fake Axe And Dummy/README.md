# Fake Axe and Dummy

Test if hero gains XP when a target dies

To do this, you need to: 

	Make Hero class testable (use Dependency Injection)
  
	Introduce Interfaces for Axe and Dummy:
  
	  Interface Weapon 
	  Interface Target 
    
Create fake Weapon and fake Dummy for the test

### Hints:

     Create IWeapon and ITarget interface. Modify implementation methods to make use of interfaces. Modify both Axe and Dummy classes.

     Use Dependency Injection for Hero class

    Create HeroTests class and test gaining XP functionality by faking Weapon and Target classes

Include Moq in the project dependencies, then:

	Mock fakes from previous problem Hints
	
Go to HeroTests and refactor the code, making use of Moq
