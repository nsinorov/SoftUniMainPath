function nestedLoops(input){
    for (let x = 1; x <= 10; x++) {
        for (let y = 1; y <=10; y++) {
            let product=x*y;
            console.log(`${x} * ${y} = ${product}`);
        }
    }
}
nestedLoops();