function nestedLoops(input) {

    let floors = Number(input[0]);
    let rooms = Number(input[1]);

    for (let i = floors; i >= 1; i--) {
        let printline = '';
        for (let j = 0; j < rooms; j++) {
            if (i == floors) {
                printline += `L${i}${j} `;
                continue;
            }

            if (i % 2 == 0) {
                printline += `O${i}${j} `;
            }

            else {
                printline += `A${i}${j} `;
            }
        }
        console.log(printline);
    }
}
nestedLoops(["6", "4"])