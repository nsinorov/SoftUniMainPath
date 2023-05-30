function trekkingMania(input){

    index = 0;
    let groupsCount = Number (input[index]);
    index++;
    let musalaMen = 0;
    let monblanMen = 0;
    let kilimangaroMen = 0;
    let k2Men = 0;
    let everestMen = 0;
    let totalMenCount = 0;

    for (let i = 0 ; i < groupsCount ; i++) {
        let menCount = Number (input[index]);
        index++;
        
        if (menCount <= 5) {
           musalaMen += menCount;
        } else if (menCount >= 6 && menCount <= 12) {
           monblanMen += menCount;
        } else if (menCount >= 13 && menCount <= 25) {
           kilimangaroMen += menCount;
        } else if (menCount >= 26 && menCount <= 40) {
           k2Men += menCount;
        } else {
           everestMen += menCount;
        }

        totalMenCount += menCount;
    }
    console.log (`${(musalaMen / totalMenCount * 100).toFixed(2)}%`);
    console.log (`${(monblanMen / totalMenCount * 100).toFixed(2)}%`);
    console.log (`${(kilimangaroMen / totalMenCount * 100).toFixed(2)}%`);
    console.log (`${(k2Men / totalMenCount * 100).toFixed(2)}%`);
    console.log (`${(everestMen / totalMenCount * 100).toFixed(2)}%`);
}

trekkingMania(["10",
"10",
"5",
"1",
"100",
"12",
"26",
"17",
"37",
"40",
"78"])
