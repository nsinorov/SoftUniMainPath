function sumNums(input){

    let num = Number(input[0]);
    let sum = 0;
    let index = 1;

    while(sum < num){
        let currNum = Number(input[index]);
        sum+=currNum;
        index++;
    }
    console.log(sum);
}

sumNums(["100", "10", "20", "30","40"])