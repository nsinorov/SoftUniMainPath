function tennisRanklist(input) {
    index = 0;
    let tournamentsCount = Number (input[index]);
    index ++;
    let startPoints = Number (input[index]);
    index ++;
    let winsCount = 0;
    let points = 0;

    for (i = 0; i < tournamentsCount ; i++) {
        let gameOver = input[index];
        index ++;
        switch (gameOver) {
            case "W": points += 2000; winsCount++ ; break;
            case "F": points += 1200; break;
            case "SF": points += 720; break;
        }
    }
    console.log (`Final points: ${points + startPoints}`)
    console.log (`Average points: ${Math.floor(points / tournamentsCount)}`)
    console.log (`${((winsCount / tournamentsCount) * 100).toFixed(2)}%`)
}

tennisRanklist(["5", "1400", "F", "SF", "W", "W", "SF"]);