function evenPowers(input){

    let number = Number(input[0]);
    let num = 1;

    for (let index = 0; index <= number ; index+=2) {
       
        console.log(num);
        num *= 4;
    }
}

evenPowers(["3"])
evenPowers(["4"])
evenPowers(["7"])