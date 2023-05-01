function passGuesser(input)
{
    let password = "s3cr3t!P@ssw0rd";

    if(input == password)
    {
        console.log("Welcome");
    }
    else
    {
        console.log("Wrong password!");
    }
}

passGuesser(["s3cr3t!P@ssw0rd"]);