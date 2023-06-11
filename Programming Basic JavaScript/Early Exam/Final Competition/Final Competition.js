function finalComp(input){

    // entry
    let dancers = Number(input.shift());
    let points = Number(input.shift());
    let season = input.shift();
    let place = input.shift();

    let money = 0;
    let charity = 0;
    let moneyPerDancer = 0;

    if (place === "Bulgaria")
     {
        if (season === "summer") 
        {
            money = dancers * points;
            money *= 0.95;
        } 
        else if (season === "winter") 
        {
            money = dancers * points;
            money *= 0.92;
        }
    } 
    else if (place === "Abroad")
     {
        if (season === "summer")
         {
            money = dancers * points;
            money *= 0.90;
            money *= 1.5;
        } 
        else if (season === "winter")
         {
            money = dancers * points;
            money *= 0.85;
            money *= 1.5;
        }
    }

    charity = money * 0.75;

    moneyPerDancer = (money - charity) / dancers;

    console.log(`Charity - ${charity.toFixed(2)}`);
    console.log(`Money per dancer - ${moneyPerDancer.toFixed(2)}`);
}

finalComp(["25",
"98",
"winter",
"Bulgaria"])