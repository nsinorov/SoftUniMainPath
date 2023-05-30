function cleverLily(input){

    let age = Number(input[0]);
    let priceOfWashingMach = Number(input[1]);
    let priceOfOneToy = Number(input[2]);

    let savedMoney = 0;


    for(let i = 1; i <= age; i++)
    {
        if(i % 2 == 0)
        {
            savedMoney += i * 5 - 1;
        }
        else
        {
            savedMoney += priceOfOneToy;
        }
    }

    if(savedMoney >= priceOfWashingMach)
    {
      console.log(`Yes! ${(savedMoney - priceOfWashingMach).toFixed(2)}`) 
    }
    else
    {
        console.log(`No! ${(priceOfWashingMach - savedMoney).toFixed(2)}`)
    }
}

cleverLily(["10",
"170.00",
"6"])


