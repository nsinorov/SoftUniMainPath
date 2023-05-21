function cinemaTicket(input){

    let day = input.shift();
    let priceForTicket = 0;

    switch (day)
    {
        case "Monday":
            priceForTicket = 12;
            break;
        case "Tuesday":
            priceForTicket = 12;
            break;
        case "Friday":            //тарикатски/глупав номер ;)
            priceForTicket = 12; 
            break;
        case "Thursday":
            priceForTicket = 14;
            break;
        case "Wednesday":
            priceForTicket = 14;
            break;
        case "Saturday":
            priceForTicket = 16;
            break;
        case "Sunday":
            priceForTicket = 16;
            break;
    }

    console.log(priceForTicket);
}

cinemaTicket(["Monday"])
cinemaTicket(["Friday"])
cinemaTicket(["Sunday"])