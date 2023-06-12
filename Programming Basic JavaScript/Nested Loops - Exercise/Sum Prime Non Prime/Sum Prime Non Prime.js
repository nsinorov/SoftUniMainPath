function prime(input) {

    let sumPrimeNum = 0;
    let sumNonPrimeNum = 0;
    let command = input.shift();

    while (command !== 'stop') {
        let num = Number(command);

        if (num < 0) {
            console.log(`Number is negative.`);
            command = input.shift();
            continue;
        }
        if (num === 1) {
            sumPrimeNum += num;
            command = input.shift();
            continue;
        }

        let isPrime = true;

        for (let i = 2; i < num; i++) {
            if (num % i === 0) {
                isPrime = false;
            }
        }
        if (isPrime) {
            sumPrimeNum += num;
        } else {
            sumNonPrimeNum += num;
        }
        command = input.shift();
    }

    console.log(`Sum of all prime numbers is: ${sumPrimeNum}`);
    console.log(`Sum of all non prime numbers is: ${sumNonPrimeNum}`);
}
prime(["3",
"9",
"0",
"7",
"19",
"4",
"stop"])