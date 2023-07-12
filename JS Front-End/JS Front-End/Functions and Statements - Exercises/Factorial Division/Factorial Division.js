function factorielSum(x,y){

    let sumX = 1;
    let sumY = 1;

    for (let index = 1; index <= x; index++) {
       
        sumX *= index;
    }

    for (let index = 1; index <= y; index++) {
       
        sumY *= index;
    }

    return (sumX / sumY).toFixed(2);
}

console.log(factorielSum(5, 2))