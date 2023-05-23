function summerOutfit(input){

    let celsius = Number(input.shift());
    let timeOfDay = input.shift();

    if (celsius >= 10 && celsius <= 18)
        {
         if (timeOfDay == "Morning")
         {
            let outfit = "Sweatshirt";
            let shoes = "Sneakers";
            console.log(`It's ${celsius} degrees, get your ${outfit} and ${shoes}.`);
          }
         else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
          {
             let outfit = "Shirt";
             let shoes = "Moccasins";
             console.log(`It's ${celsius} degrees, get your ${outfit} and ${shoes}.`);
           }
        }

        if(celsius > 18 && celsius <= 24)
                {
                    if(timeOfDay == "Afternoon")
                    {
                        let outfit = "T-Shirt";
                        let shoes = "Sandals";
                        console.log(`It's ${celsius} degrees, get your ${outfit} and ${shoes}.`);
                    }
                    else if(timeOfDay == "Morning" || timeOfDay == "Evening")
                    {
                        let outfit = "Shirt";
                        let shoes = "Moccasins";
                        console.log(`It's ${celsius} degrees, get your ${outfit} and ${shoes}.`);
                    }
                }
        
                if(celsius >= 25)
                {
                    if(timeOfDay == "Morning")
                    {
                        let outfit = "T-Shirt";
                        let shoes = "Sandals";
                        console.log(`It's ${celsius} degrees, get your ${outfit} and ${shoes}.`);
                    }
                    else if(timeOfDay == "Afternoon")
                    {
                        let outfit = "Swim Suit";
                        let shoes = "Barefoot";
                        console.log(`It's ${celsius} degrees, get your ${outfit} and ${shoes}.`);
                    }
                    else if(timeOfDay == "Evening")
                    {
                        let outfit = "Shirt";
                        let shoes = "Moccasins";
                        console.log(`It's ${celsius} degrees, get your ${outfit} and ${shoes}.`);
                    }
                }                   
}

summerOutfit(["16",
"Morning"])

summerOutfit(["22",
"Afternoon"])

summerOutfit(["28",
"Evening"])