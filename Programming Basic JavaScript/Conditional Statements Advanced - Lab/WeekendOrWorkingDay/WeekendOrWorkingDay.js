function WeekendWorkingDay(input)
{
    let day = input.shift();

    switch (day) 
    {
        case "Monday": 
        case "Tuesday":
        case "Wednesday":
        case "Thursday":
        case "Friday":
         console.log("Working day");
        break;

        case "Saturday":
        case "Sunday":
            console.log("Weekend");
            break;
         default:
            console.log("Error");
            break;
    }

}

WeekendWorkingDay(["Monday"]);
WeekendWorkingDay(["Sunday"]);
WeekendWorkingDay(["April"]);