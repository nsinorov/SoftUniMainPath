function walking(params){
   
    let steps = 0;

    while (params.length > 0) {
        let command = params.shift();

        if (command === 'Going home') {
            steps += Number(params.shift());
            (steps >= 10000) 
            ? console.log(`Goal reached! Good job!\n${steps - 10000} steps over the goal!`) 
            : console.log(`${10000 - steps} more steps to reach goal.`);
            break;
        }
        steps += Number(command);
        if (steps >= 10000) {
            console.log(`Goal reached! Good job!\n${steps - 10000} steps over the goal!`);
            break;
        }
    }
}

walking([1500,
    3000,
    250,
    1548,
    2000,
    `Going home`,
    2000])