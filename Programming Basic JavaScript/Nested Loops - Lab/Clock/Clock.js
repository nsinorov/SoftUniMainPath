function nestedLoops(input){

    for (let hour = 0; hour <= 23; hour++) {
        for (let mins = 0; mins <= 59; mins++) {
            console.log(`${hour}:${mins}`);
        }
    }
}
nestedLoops();