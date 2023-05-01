function evenOdd(input)
{
    let num = Number(input[0]);

    if(num % 2 == 0)
    {
        console.log("even");
    }
    else
    {
        console.log("odd");
    }
}

evenOdd(["25"]);