function accountBalance(input){

    let index = 0;
    let total = 0;
    let command = input[index];
    index ++
    
    while (command !== "NoMoreMoney" ) {
       let sum = Number(command);
       
       if (sum < 0) {
           console.log(`Invalid operation!`);
           break;
       }
        console.log(`Increase: ${sum.toFixed(2)}`);
        total += sum;
        command = input[index];
        index++
    }
    console.log(`Total: ${total.toFixed(2)}`)
}

accountBalance(["5.51", "69.42", "100", "NoMoreMoney"])