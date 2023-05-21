function tradeCommission(input){

    let town = input.shift();
    let sales = Number(input.shift());
    let commision = 0.00;

    switch (town)
            {
                case "Sofia":
                    if(0 <= sales && sales <= 500)
                    {
                        commision = 0.05;
                    }
                    else if(500 < sales && sales <= 1000)
                    {
                        commision = 0.07;
                    }
                    else if (1000 < sales && sales <=10000)
                    {
                        commision = 0.08;
                    }
                    else if(sales > 10000)
                    {
                        commision = 0.12;
                    }
                    else
                    {
                        console.log("error");
                    }

                    break;
                case "Varna":
                    if (0 <= sales && sales <= 500)
                    {
                        commision = 0.045;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commision = 0.075;
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        commision = 0.1;
                    }
                    else if (sales > 10000)
                    {
                        commision = 0.13;
                    }
                    else
                    {
                        console.log("error");
                    }
                    break;
                case "Plovdiv":
                    if (0 <= sales && sales <= 500)
                    {
                        commision = 0.055;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commision = 0.08;
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        commision = 0.12;
                    }
                    else if (sales > 10000)
                    {
                        commision = 0.145;
                    }
                    else
                    {
                        console.log("error");
                    }
                    break;
                default:
                    console.log("error");
                    break;
            }

            let totalSum = sales * commision;

            if(commision > 0)
            {
                console.log(`${totalSum.toFixed(2)}`);
            }
}

tradeCommission(["Sofia",
"1500"])

tradeCommission(["Plovdiv",
"499.99"])

tradeCommission(["Varna",
"3874.50"])

tradeCommission(["Kaspichan",
"-50"])

