function cinemaTickets(input) {

    let command = input.shift();
    let totalStudents = 0;
    let totalStandarts = 0;
    let totalKids = 0;
    let totalTickets = 0;

    while (command != "Finish") {
        let students = 0;
        let standart = 0;
        let kid = 0;
        let freeSpots = Number(input.shift());
        for (let i = 0; i < freeSpots; i++) {
            let ticketType = input.shift();
            if (ticketType == "End") {
                break;
            }
            switch (ticketType) {
                case "student":
                    students++;
                    break;
                case "standard":
                    standart++;
                    break;
                case "kid":
                    kid++;
                    break;
            }
        }
        totalStudents += students;
        totalStandarts += standart;
        totalKids += kid;

        let perecentageFull = (students + standart + kid) / (freeSpots * 1.0) * 100;
        console.log(`${command} - ${perecentageFull.toFixed(2)}% full.`)
        command = input.shift();
    }
    totalTickets = totalStudents + totalStandarts + totalKids;
    console.log(`Total tickets: ${totalTickets}`)
    let standartPercentage = totalStandarts / (totalTickets * 1.0) * 100;
    let studentPercentage = totalStudents / (totalTickets * 1.0) * 100;
    let kidsPercentage = totalKids / (totalTickets * 1.0) * 100;

    console.log(`${studentPercentage.toFixed(2)}% student tickets.`);
    console.log(`${standartPercentage.toFixed(2)}% standard tickets.`);
    console.log(`${kidsPercentage.toFixed(2)}% kids tickets.`);
}
cinemaTickets(["The Matrix",
"20",
"student",
"standard",
"kid",
"kid",
"student",
"student",
"standard",
"student",
"End",
"The Green Mile",
"17",
"student",
"standard",
"standard",
"student",
"standard",
"student",
"End",
"Amadeus",
"3",
"standard",
"standard",
"standard",
"Finish"])