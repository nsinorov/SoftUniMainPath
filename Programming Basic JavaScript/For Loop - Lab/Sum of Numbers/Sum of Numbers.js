function sumNums(input){
    let num = input[0];
    let sum = 0;
    for (let i = 0; i < num.length; i++) {
        sum += Number(num[i]);
    }
    console.log(`The sum of the digits is:${sum}`);
}

sumNums(["1234"])
sumNums(["564891"])
