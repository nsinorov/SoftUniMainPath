function computerFirm(input) 
{
    let index = 0;
    let pcCounter = Number (input[index]);

    index ++;
  
    let rate = 0;
    let rateCounter = 0;
    let sales = 0

    for (let i = 0;i < pcCounter; i++) 
    {
        let num = "" + input[index];
        index++;

        let rating =num[2];
        let score = Number(rating)
        let possSales = `${num[0]}${num[1]}`;
        let chanceSales = Number(possSales)

        rate += score;
        rateCounter++;

        switch(rating)
         {
            case "2": sales += 0; break;
            case "3": sales += chanceSales * 0.5; break;
            case "4": sales += chanceSales * 0.7; break;
            case "5": sales += chanceSales * 0.85; break;
            case "6": sales += chanceSales; break;
        }
    }

    console.log(sales.toFixed(2));
    console.log((rate / rateCounter).toFixed(2));

}

computerFirm(["5",
"122",
"156",
"202",
"214",
"185"])