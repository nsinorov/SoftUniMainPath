function christmasPrep(input){

    let numOfRoll = Number(input[0]);
    let numOfPlat = Number(input[1]);
    let litersGlue = Number(input[2]);
    let percentDiscount = Number(input[3]);

    let sum = numOfRoll * 5.8 + numOfPlat * 7.2 + litersGlue * 1.2;
    let finalSum = sum - (sum * percentDiscount) / 100;

    console.log(finalSum.toFixed(3));
}

christmasPrep(["2", "3", "2.5", "25"]);
christmasPrep(["4","2","5","13"]);

