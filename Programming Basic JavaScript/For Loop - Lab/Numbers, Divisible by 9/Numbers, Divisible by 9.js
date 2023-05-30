function numsDivisibleBy9(input){

    let firstNum=Number(input[0]);
    let secondNum=Number(input[1]);
    let sum=0;

    for (let i = firstNum; i <= secondNum; i++) {
        if (i%9===0) {
            sum+=i;
        }
    }
    console.log(`The sum: ${sum}`);

    for (let i = firstNum; i <= secondNum; i++) {
        if (i%9===0) {
            console.log(i);
        }
    }
}

numsDivisibleBy9(["100", "200"])