using Prototype.Models;

SandwichMenu sandwichMenu = new();

sandwichMenu["BLT"] = new Sandwich("Wheat", "Bacon", "", "Letuce, Tomato");
sandwichMenu["PB&J"] = new Sandwich("White", "", "", "Peanut Butter, Jelly");
sandwichMenu["Turkey"] = new Sandwich("Rye", "Turkey", "Swiss", "Letuce, Onion, Tomato");

sandwichMenu["LoadedBLT"] = new Sandwich("Wheat", "Turkey, Bacon", "American", "Letuce, Tomato, Onion, Olives");
sandwichMenu["ThreeMeatCombo"] = new Sandwich("Rye", "Turkey, Ham, Salami", "Provolone", "Letuce, Onion");
sandwichMenu["Vegeterian"] = new Sandwich("Wheat", "", "", "Letuce, Onion, Tomato, Olives, Spinach");

Sandwich sandwich1 = sandwichMenu["BLT"].Clone() as Sandwich;
Sandwich sandwich2 = sandwichMenu["ThreeMeatCombo"].Clone() as Sandwich;
Sandwich sandwich3 = sandwichMenu["Vegeterian"].Clone() as Sandwich;