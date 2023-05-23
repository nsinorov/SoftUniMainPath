function skiTrip(input){

    let daysStaying = Number(input.shift());
    let typeOfRoom = input.shift()
    let score = input.shift()
    daysStaying = daysStaying - 1;
    let midSum = 0;
    let totalSum = 0;

    if(typeOfRoom == "room for one person" && daysStaying < 10)
            {
                midSum = daysStaying * 18.00;            
            }

          else if(typeOfRoom == "room for one person" && daysStaying < 15)
            {
                midSum = daysStaying * 18.00;            
            }

          else if(typeOfRoom == "room for one person" && daysStaying > 15)
            {
                midSum = daysStaying * 18.00;         
            }

            if (typeOfRoom == "apartment" && daysStaying < 10)
            {
                midSum = (daysStaying * 25.00);
                midSum = midSum - (midSum * 0.3);
            }

          else if(typeOfRoom == "apartment" && daysStaying < 15)
            {
                midSum = (daysStaying * 25.00);
                midSum = midSum - (midSum * 0.35);           
            }

          else if(typeOfRoom == "apartment" && daysStaying > 15)
            {
                midSum = (daysStaying * 25.00);
                midSum = midSum - (midSum * 0.5);
            }

          if(typeOfRoom == "president apartment" && daysStaying < 10)
            {
                midSum = (daysStaying * 35.00);
                midSum = midSum - (midSum * 0.1);
            }

          else if(typeOfRoom == "president apartment" && daysStaying < 15)
            {
                midSum = (daysStaying * 35.00);
                midSum = midSum - (midSum * 0.15);
            }

            else if (typeOfRoom == "president apartment" && daysStaying > 15)
            {
                midSum = (daysStaying * 35.00);
                midSum = midSum - (midSum * 0.2);
            }

            if(score == "positive")
            {
                totalSum = midSum + (midSum * 0.25);
                console.log(`${totalSum.toFixed(2)}`);
            }

            else if(score == "negative")
            {
                totalSum = midSum - (midSum * 0.1);
                console.log(`${totalSum.toFixed(2)}`);
            }
}

skiTrip(["14",
"apartment",
"positive"])

skiTrip(["30",
"president apartment",
"negative"])

skiTrip(["12",
"room for one person",
"positive"])

skiTrip(["2",
"apartment",
"positive"])
