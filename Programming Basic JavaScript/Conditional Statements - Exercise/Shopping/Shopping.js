function shopping(input)
{
    let budged = Number(input.shift());
    let numVideoCards = Number(input.shift());
    let numCPU = Number(input.shift());
    let numRams = Number(input.shift());

    let priceForVideoCards = numVideoCards * 250;

    let priceOfCPU = 0.35 * priceForVideoCards;
    let sumOfCPUs = numCPU * priceOfCPU;
    let priceForRam = 0.1 * priceForVideoCards;
    let sumOfRam = numRams * priceForRam;
    let totalSum = priceForVideoCards + sumOfCPUs + sumOfRam;

    if (numVideoCards > numCPU) 
    {
        totalSum *= 0.85;
    }

    let finalSum = Math.abs(totalSum - budged).toFixed(2);

    if (totalSum <= budged) {
        console.log(`You have ${finalSum} leva left!`);
    } else {
        console.log(`Not enough money! You need ${finalSum} leva more!`);
    }
}

shopping(['900','2','1','3']);
shopping(['920.45','3','1','1']);