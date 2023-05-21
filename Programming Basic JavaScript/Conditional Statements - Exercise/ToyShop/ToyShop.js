function toyShop(input)
{
    let priceForVacation = Number(input[0]);
    let numPuzzles = Number(input[1]);
    let numDolls = Number(input[2]);
    let numBears = Number(input[3]);
    let numMinions = Number(input[4]);
    let numTrucks = Number(input[5]);

    let puzzlePrice = numPuzzles *2.60;
    let priceDoll = numDolls * 3;
    let priceBear = numBears * 4.10;
    let priceMinion = numMinions * 8.20;
    let priceTruck = numTrucks * 2;

    let totalQuantity = numPuzzles + numDolls + numBears + numMinions + numTrucks;

    let priceSum = puzzlePrice + priceDoll + priceBear + priceMinion + priceTruck;

    if (totalQuantity >= 50)
        {
         priceSum -= priceSum * 0.25;
        }

         priceSum -= priceSum * 0.1;
    
    if(priceSum >= priceForVacation)
     {
        priceSum -= priceForVacation;
        console.log(`Yes! ${priceSum.toFixed(2)} lv left.`);
     }

     else
     {
        priceForVacation -= priceSum;
        console.log(`Not enough money! ${priceForVacation.toFixed(2)} lv needed.`);
     }
}

toyShop(["40.8",
"20",
"25",
"30",
"50",
"10"])
