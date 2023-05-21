function invalidNumber(input){

    let num = Number(input.shift());

    let isValid = num >= 100 && num <= 200 || num == 0;

    if (!isValid)
    {
     console.log("invalid");
    }
}

invalidNumber(["75"])
invalidNumber(["150"])
invalidNumber(["220"])
invalidNumber(["199"])
invalidNumber(["-1"])
invalidNumber(["100"])