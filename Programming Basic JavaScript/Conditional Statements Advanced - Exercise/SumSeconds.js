function sumSeconds(input)
{
    let firstTime = Number(input[0]);
    let secondTime = Number(input[1]);
    let thirdTime = Number(input[2]);

    let totalTime = firstTime + secondTime + thirdTime;

    let min = Math.floor(totalTime / 60);
    let sec = totalTime % 60;

    if(sec < 10)
    {
        console.log(`${min}:0${sec}`)
    }
    else{
        console.log(`${min}:${sec}`);
    }
}

sumSeconds(["35","45","44"]);