function sequence(input){

    let number = Number(input[0]);
    let k = 1;
    let index = 0;

    while(k <= number){
        console.log(k);
        number = input[index];
        k = k*2+1;
    }
}

sequence(["3"])