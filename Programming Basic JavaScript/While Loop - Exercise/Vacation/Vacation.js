function vac(input){

    let neededMoney = Number(input[0]);
    let availableMoney = Number(input[1]);

    let money = 0;
    let daysCount = 0;
    let spendCount = 0;
    let index = 2;

    while(availableMoney < neededMoney){
        let action = input[index];
        index++;
        money = Number(input[index]);
        index++;
        daysCount++;

        if(action === "save"){
            availableMoney += money;
            spendCount = 0;
        }
        else{
            availableMoney -= money;
            if(availableMoney < 0){
                availableMoney = 0;
            }
            spendCount++;
            if(spendCount === 5){
                console.log(`You can't save the money.`);
                console.log(`${daysCount}`);
                break;
            }
        }
    }
    if(availableMoney >= neededMoney){
        console.log(`You saved the money for ${daysCount} days.`);
    }
}

vac(["2000", "1000", "spend", "1200", "save", "2000"])