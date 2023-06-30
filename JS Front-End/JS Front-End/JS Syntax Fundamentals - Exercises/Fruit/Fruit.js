function solve(fruit, weightInGrams, priceInKilo){

const weightInKilo = weightInGrams / 1000;
const totalPrice = weightInKilo * priceInKilo;

console.log(`I need $${totalPrice.toFixed(2)} to buy ${weightInKilo.toFixed(2)} kilograms ${fruit}.`);
}

solve('orange', 2500, 1.80)