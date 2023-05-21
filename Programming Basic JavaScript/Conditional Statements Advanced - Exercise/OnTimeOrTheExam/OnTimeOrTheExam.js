function onTimeForTheExam(input) {
    const examHour = Number (input[0]);
    const examMinutes = Number (input[1]);
    const arriveHour = Number (input[2]);
    const arriveMinutes = Number (input[3]);
    
    const examTime = (examHour * 60) + examMinutes;
    const arriveTime = (arriveHour * 60) + arriveMinutes;
    const timeDifference = Math.abs(examTime - arriveTime);
    const hour = Math.floor(timeDifference / 60);
    let minutes = timeDifference % 60;
    let note = "";

    if (arriveTime < examTime && timeDifference > 30) {
        note = "Early"
    } else if (arriveTime > examTime) {
        note = "Late"
    } else {
        note = "On time"
    }
    switch (note) {
        case "On time":
        if (timeDifference <= 30) {    
             console.log (`on time ${minutes} minutes before the start`)
            }; break;
        case "Early": 
        if (timeDifference <= 59) {
            console.log (`early ${minutes} minutes before the start`);
        } else if (timeDifference > 59 ) {
            if (minutes < 10) {
                console.log (`early ${hour}:${0}${minutes} hours before the start`)
            } else {
                console.log(`early ${hour}:${minutes} hours before the start`)
            }
        } ; break;
        case "Late":
            if (timeDifference <= 59) {
                console.log (`late ${minutes} minutes after the start`);
            } else if (timeDifference > 59 ) {
                if (minutes < 10) {
                    console.log (`late ${hour}:${0}${minutes} hours after the start`)
                } else {
                    console.log(`late ${hour}:${minutes} hours after the start`)
                }
            } ; break;

    }
}

onTimeForTheExam(["9", "00", "8", "30"]);