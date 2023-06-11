function travelling(input){
    let detination=input.shift();
    let neededMoney=Number(input.shift());
    let money=0;
    while (detination!="End") {
 
        while (money<neededMoney) {
            let moneySaved=Number(input.shift());
            money+=moneySaved;
            if (money>=neededMoney) {
                console.log(`Going to ${detination}!`);
 
            }
        }
        money=0;
        detination=input.shift();
        neededMoney=Number(input.shift());
    }
}
travelling(["Greece",
"1000",
"200",
"200",
"300",
"100",
"150",
"240",
"Spain",
"1200",
"300",
"500",
"193",
"423",
"End"])