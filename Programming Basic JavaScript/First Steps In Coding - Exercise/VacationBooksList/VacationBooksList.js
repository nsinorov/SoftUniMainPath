function vacationBookList(input)
{
    let numsOfPagesInCurrentBook = Number(input[0]);
    let numsOfPagesForOneHour = Number(input[1]);
    let numsOfDays = Number(input[2]);

    let neededHoursDay = numsOfPagesInCurrentBook / numsOfPagesForOneHour;
    let numsOfHoursNeeded = neededHoursDay / numsOfDays;

    console.log(numsOfHoursNeeded);
}

vacationBookList(["212","20","2"]);