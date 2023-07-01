function solve(num){


    const  CONSUMED_BY_WORKERS = 26;
    const  MIN_SPICES_TO_GATHER = 100;
    const  DAILY_DECREES_OF_MINE_YIELD = 10;

    let countOfSpices = num;
    let totalConsumed = 0;
    let daysCount = 0;

            while(countOfSpices >= MIN_SPICES_TO_GATHER)
            {
                totalConsumed += countOfSpices - CONSUMED_BY_WORKERS;
                countOfSpices -= DAILY_DECREES_OF_MINE_YIELD;
                daysCount++;

                if(countOfSpices < MIN_SPICES_TO_GATHER)
                {
                    totalConsumed -= CONSUMED_BY_WORKERS;
                }
            }

            console.log(daysCount);
            console.log(totalConsumed);
    }

    
solve(111)