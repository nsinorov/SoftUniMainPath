function newHouse(input){

    let flower = input.shift();
    let numOfFlowers = Number(input.shift());
    let budget = Number(input.shift());

    let roses = 5.00;
    let dahlias = 3.80;
    let tulips = 2.80;
    let narcissus = 3.00;
    let gladiolus = 2.50;

    let totalSum = 0.00;
    let tempSum;

    switch (flower)
            {
                case "Roses":

                    tempSum = roses * numOfFlowers;
                    totalSum = tempSum;

                    if(numOfFlowers > 80)
                    {
                        totalSum = tempSum - (tempSum * 0.1);
                       
                    }
                    break;

                case "Dahlias":

                    tempSum = dahlias * numOfFlowers;
                    totalSum = tempSum; 
                    
                    if(numOfFlowers > 90)
                    {
                        totalSum = tempSum - (tempSum * 0.15);
                    }
                    break;

                case "Tulips":
                    tempSum = tulips * numOfFlowers;
                    totalSum = tempSum;

                    if(numOfFlowers > 80)
                    {
                        totalSum = tempSum - (tempSum * 0.15);
                    }
                    break;

                case "Narcissus":
                    tempSum = narcissus * numOfFlowers;
                    totalSum = tempSum;

                    if(numOfFlowers < 120)
                    {
                        totalSum = tempSum + (tempSum * 0.15);
                    }
                    break;

                case "Gladiolus":
                    tempSum = gladiolus * numOfFlowers;
                    totalSum = tempSum;

                    if(numOfFlowers < 80)
                    {
                        totalSum = tempSum + (tempSum * 0.2);
                    }
                    break;
            }

            if(budget >= totalSum)
            {
                console.log(`Hey, you have a great garden with ${numOfFlowers} ${flower} and ${(budget - totalSum).toFixed(2)} leva left.`);
            }
            else
            {
                console.log(`Not enough money, you need ${(totalSum - budget).toFixed(2)} leva more.`);
            }        
}

newHouse(["Roses",
"55",
"250"])


newHouse(["Tulips",
"88",
"260"])


newHouse(["Narcissus","119","360"])

