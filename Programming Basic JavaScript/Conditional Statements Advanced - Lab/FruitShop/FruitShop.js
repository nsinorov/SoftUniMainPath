function fruitShop(input){

    let fruit = input.shift();
    let dayOfWeek = input.shift();
    let quantity = Number(input.shift());

    let totalPrice = 0.00;

    switch (dayOfWeek)
            {
                case "Monday":                  
                case "Tuesday":                 
                case "Wednesday":                  
                case "Thursday":                
                case "Friday":
   
                    switch (fruit)
                    {
                        case "banana":
                            totalPrice = quantity * 2.50;
                            break;
                        case "apple":
                            totalPrice = quantity * 1.20;
                            break;
                        case "orange":
                            totalPrice = quantity * 0.85;
                            break;
                        case "grapefruit":
                            totalPrice = quantity * 1.45;
                            break;
                        case "kiwi":
                            totalPrice = quantity * 2.70;
                            break;
                        case "pineapple":
                            totalPrice = quantity * 5.50;
                            break;
                        case "grapes":
                            totalPrice = quantity * 3.85;
                            break;
                        default:
                            console.log("error");
                            break;
                    }
                    break;

                case "Saturday":                
                case "Sunday":
              
                    switch (fruit)
                    {
                        case "banana":
                            totalPrice = quantity * 2.70;
                            break;
                        case "apple":
                            totalPrice = quantity * 1.25;
                            break;
                        case "orange":
                            totalPrice = quantity * 0.90;
                            break;
                        case "grapefruit":
                            totalPrice = quantity * 1.60;
                            break;
                        case "kiwi":
                            totalPrice = quantity * 3.00;
                            break;
                        case "pineapple":
                            totalPrice = quantity * 5.60;
                            break;
                        case "grapes":
                            totalPrice = quantity * 4.20;
                            break;
                        default:
                            console.log("error");
                            break;
                    }
                    break;
                default:
                    console.log("error");
                    break;
            }
            if (totalPrice > 0)
            {
                console.log(`${totalPrice.toFixed(2)}`);
            }                  
}

fruitShop(["apple",
"Tuesday",
"2"])

fruitShop(["orange",
"Sunday",
"3"])

fruitShop(["kiwi",
"Monday",
"2.5"])

fruitShop(["grapes",
"Saturday",
"0.5"])

fruitShop(["tomato",
"Monday",
"0.5"])
