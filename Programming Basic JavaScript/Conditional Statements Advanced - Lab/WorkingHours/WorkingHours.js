function workingHours(input){

    let hour = Number(input.shift());
    let day = input.shift();

    if (hour >= 10 && hour <= 18 && (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday"))
    {
        console.log("open");
    } 
    else
    {
        console.log("closed");
    }
}

workingHours(["11",
"Monday"])

workingHours(["19",
"Friday"])

workingHours(["11",
"Sunday"])
