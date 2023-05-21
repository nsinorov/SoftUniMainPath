function hotelRoom(input){

    let mount = input.shift();
    let night = Number(input.shift());
    let apartment = night;
    let studio = night;

    if (mount == "May" || mount == "October")
            {
                apartment *= 65;
                studio *= 50;

                if (night > 7 && night <= 14)
                {
                    studio *= 0.95;
                }
                else if (night > 14)
                {
                    apartment *= 0.9;
                    studio *= 0.7;
                }
            }
            if (mount == "June" || mount == "September")
            {
                apartment *= 68.7;
                studio *= 75.2;

                if (night > 14)
                {
                    apartment *= 0.9;
                    studio *= 0.8;
                }
            }
            if (mount == "July" || mount == "August")
            {
                apartment *= 77;
                studio *= 76;

                if (night > 14)
                {
                    apartment *= 0.9;
                }
            }

            console.log(`Apartment: ${apartment.toFixed(2)} lv.`);
            console.log(`Studio: ${studio.toFixed(2)} lv.`);
}

hotelRoom(["May",
"15"])

hotelRoom(["June",
"14"])

hotelRoom(["August",
"20"])
