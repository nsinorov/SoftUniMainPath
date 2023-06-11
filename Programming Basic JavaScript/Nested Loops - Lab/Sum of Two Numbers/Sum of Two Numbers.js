function nestedLoops(input) {

    let start = Number(input[0]);
    let end = Number(input[1]);
    let magicNum = Number(input[2]);
    let counter = 0;

    for (let num1 = start; num1 <= end; num1++) {
        for (let num2 = start; num2 <= end; num2++) {
            counter++;
            let sum = num1 + num2;
            if (sum == magicNum) {
                console.log(`Combination N:${counter} (${num1} + ${num2} = ${magicNum})`);
                return;
            }
        }
    }
    console.log(`${counter} combinations - neither equals ${magicNum}`)
}
nestedLoops(["1",
"10",
"5"])