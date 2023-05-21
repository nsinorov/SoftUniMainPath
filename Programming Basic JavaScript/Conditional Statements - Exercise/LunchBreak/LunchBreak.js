function lunchBreak(input)
{
    let nameOfSeries = input.shift();
    let lenghtOfEpisode = Number(input.shift());
    let lenghtOfBreak = Number(input.shift());

    let timeForLunch = lenghtOfBreak * 5 / 8.0;

    if(timeForLunch >= lenghtOfEpisode)
    {
        console.log(`You have enough time to watch ${nameOfSeries} and left with ${Math.ceil(timeForLunch - lenghtOfEpisode)} minutes free time.`);
    }
    else
    {
        console.log(`You don't have enough time to watch ${nameOfSeries}, you need ${Math.ceil(lenghtOfEpisode - timeForLunch)} more minutes.`);
    }

}

lunchBreak(["Game of Thrones",
"60",
"96"])

lunchBreak(["Teen Wolf",
"48",
"60"])
