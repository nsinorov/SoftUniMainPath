function footballKit(input){

    let priceOfOneShirt = Number(input[0]);
    let budgedNeeded = Number(input[1]);

    let priceOfShorts = priceOfOneShirt * 0.75;
    let priceOfSocks = priceOfShorts * 0.20;
    let priceOfButonki = (priceOfOneShirt + priceOfShorts) * 2;
    let totalSum = priceOfOneShirt + priceOfShorts + priceOfSocks + priceOfButonki;
    let sumAfterDiscount = totalSum - (totalSum * 0.15);

    if(sumAfterDiscount >= budgedNeeded)
    {
       console.log(`Yes, he will earn the world-cup replica ball!`);
       console.log(`His sum is ${sumAfterDiscount.toFixed(2)} lv.`);            
    }
    else
    {
        console.log(`No, he will not earn the world-cup replica ball.`);
        console.log(`He needs ${Math.abs(sumAfterDiscount - budgedNeeded).toFixed(2)} lv. more.`);
    }
}

footballKit(["25",
"100"])

footballKit(["55",
"310"])

footballKit(["59.99",
"500"])
