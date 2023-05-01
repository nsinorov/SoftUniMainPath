function greaterNumber(input)
{
    let numOne = Number(input[0]);
    let numTwo = Number(input[1]);

    if(numOne > numTwo)
    {
        console.log(numOne)
    }
    else
    {
        console.log(numTwo)
    }
}

greaterNumber(["5", "3"]);