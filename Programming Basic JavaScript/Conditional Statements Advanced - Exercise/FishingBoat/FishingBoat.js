function fishingBoat(input){

    let budget = Number(input.shift());
    let season = input.shift()
    let numOfFishermens  = Number(input.shift());
    let totalSum = 0;

    switch (season)
    {
        case "Spring":

            if (numOfFishermens <= 6)
            {
                let discount = 0.1;
                totalSum = 3000 - (3000 * discount);
            }
            else if (numOfFishermens >= 7 && numOfFishermens <= 11)
            {
                let discount = 0.15;
                totalSum = 3000 - (3000 * discount);
            }
            else if (numOfFishermens >= 12)
            {
                let discount = 0.25;
                totalSum = 3000 - (3000 * discount);
            }
            break;

        case "Summer":
        case "Autumn":

            if (numOfFishermens <= 6)
            {
                let discount = 0.1;
                totalSum = 4200 - (4200 * discount);
            }
            else if (numOfFishermens <= 11)
            {
                let discount = 0.15;
                totalSum = 4200 - (4200 * discount);

            }
            else if (numOfFishermens >= 12)
            {
                let discount = 0.25;
                totalSum = 4200 - (4200 * discount);
            }
            break;

        case "Winter":

            if (numOfFishermens <= 6)
            {
                let discount = 0.1;
                totalSum = 2600 - (2600 * discount);
            }
            else if (numOfFishermens <= 11)
            {
                let discount = 0.15;
                totalSum = 2600 - (2600 * discount);

            }
            else if (numOfFishermens >= 12)
            {
                let discount = 0.25;
                totalSum = 2600 - (2600 * discount);
            }
            break;
    }


    if ((numOfFishermens % 2 == 0) && (season != "Autumn"))
            {
                 totalSum = totalSum - (totalSum * 0.05);              
            }

            if (budget >= totalSum)
            {
                console.log(`Yes! You have ${(budget - totalSum).toFixed(2)} leva left.`);
            }
            else
            {
                console.log(`Not enough money! You need ${(totalSum - budget).toFixed(2)} leva.`);
            }

}

fishingBoat(["3000",
"Summer",
"11"])

fishingBoat(["3600",
"Autumn",
"6"])

fishingBoat(["2000",
"Winter",
"13"])

