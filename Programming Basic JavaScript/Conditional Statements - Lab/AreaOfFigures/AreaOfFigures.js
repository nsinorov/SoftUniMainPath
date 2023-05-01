function areaOfFifures(input)
{
    let figure = input[0];

    if(figure === "square")
    {
        let num = Number(input[1]);

        console.log((num * num).toFixed(3));
    }
    else if(figure === "rectangle")
    {
        let num1 = Number(input[1]);
        let num2 = Number(input[2]);

        console.log((num1 * num2).toFixed(3));
    }
    else if(figure === "circle")
    {
        let num = Number(input[1]);

        console.log((Math.PI * num * num).toFixed(3));
    }
    else if(figure === "triangle")
    {
        let num1 = Number(input[1]);
        let num2 = Number(input[2]);

        console.log((num1 * num2 / 2).toFixed(3));
    }
}

areaOfFifures(["triangle","4.5","20"])


