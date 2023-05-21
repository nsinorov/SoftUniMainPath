function time_Minutes(input)
{
    let hours = Number(input[0]);
    let min = Number(input[1]);

    min+= (hours * 60);

    let minAfter15Min = min + 15;

    let hourAfter = Math.floor(minAfter15Min / 60);
    let minAfter = minAfter15Min % 60;

    if (hourAfter > 23)
            {
                hourAfter = 0;
            }

            if ( minAfter < 10)
            {
               console.log(`${hourAfter}:0${minAfter}`);
            }
            else
            {
             console.log(`${hourAfter}:${minAfter}`);
            }
}

time_Minutes(["0", "01"])