function cinema(input){

    let projection = input.shift();
    let row = input.shift();
    let column = Number(input.shift());

    let premiere = 12.00;
    let normal = 7.50;
    let discount = 5.00;
    let totalSum = 0.00;

    if(projection == "Premiere")
            {
                totalSum = (row * column) * premiere;
            }
            else if(projection == "Normal")
            {
                totalSum = (row * column) * normal;             
            }
            else if(projection == "Discount")
            {
                totalSum = (row * column) * discount;           
            }

    console.log(`${totalSum.toFixed(2)}`);

}

cinema(["Premiere",
"10",
"12"])

cinema(["Normal",
"21",
"13"])

cinema(["Discount",
"12",
"30"])
