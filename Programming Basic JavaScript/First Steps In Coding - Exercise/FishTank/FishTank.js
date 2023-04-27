function fishTank(input)
{
    let lenght = Number(input[0]);
    let width = Number(input[1]);
    let height = Number(input[2]);
    let percent = Number(input[3]) / 100;

    let areaOfAquarium = lenght * width * height;
    let areaInLiters = areaOfAquarium / 1000;

    let neededLiters = areaInLiters * (1 - percent);

    console.log(neededLiters);
}

fishTank(["85 ",
"75 ",
"47 ",
"17 "]
);