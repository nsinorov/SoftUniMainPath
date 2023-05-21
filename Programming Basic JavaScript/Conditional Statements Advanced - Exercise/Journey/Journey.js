function journey(input){

    let budget = Number(input.shift());
    let season = input.shift();
    let totalSummer = 0.00;    
    let totalWinter = 0.00;


    if(budget <= 100)
            {
                switch (season)
                {
                    case "summer":
                        totalSummer = budget * 0.3;
                        console.log("Somewhere in Bulgaria");
                        console.log(`Camp - ${totalSummer.toFixed(2)}`);
                        break;
                    case "winter":
                        totalWinter = budget * 0.7;
                        console.log("Somewhere in Bulgaria");
                        console.log(`Hotel - ${totalWinter.toFixed(2)}`);
                        break;
                }
            }
            else if(budget <= 1000)
            {
                switch (season)
                {
                    case "summer":
                        totalSummer = budget * 0.4;
                        console.log("Somewhere in Balkans");
                        console.log(`Camp - ${totalSummer.toFixed(2)}`);
                        break;
                    case "winter":
                        totalWinter = budget * 0.8;
                        console.log("Somewhere in Balkans");
                        console.log(`Hotel - ${totalWinter.toFixed(2)}`);
                        break;
                }
            }
            else if(budget > 1000)
            {
                budget = budget * 0.9;
                console.log("Somewhere in Europe");
                console.log(`Hotel - ${budget.toFixed(2)}`);
            }   
}

journey(["50", "summer"])
journey(["75", "winter"])
journey(["312", "summer"])
journey(["678.53", "winter"])
journey(["1500", "summer"])
