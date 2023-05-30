function multiplicationTAble(input){

    let num = Number(input[0]);

    for (let index = 1; index <= 10; index++) {
       
        console.log(`${index} * ${num} = ${index * num}`);
    }
}

multiplicationTAble(["5"])