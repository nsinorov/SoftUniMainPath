function coins(input){

    const money = Number(input[0]);
    let sum = parseInt(money * 100);
    let coinsCounter = 0;
  
    while (sum > 0) {
      if (sum >= 200) {
        sum -= 200;
      } else if (sum >= 100) {
        sum -= 100;
      } else if (sum >= 50) {
        sum -= 50;
      } else if (sum >= 20) {
        sum -= 20;
      } else if (sum >= 10) {
        sum -= 10;
      } else if (sum >= 5) {
        sum -= 5;
      } else if (sum >= 2) {
        sum -= 2;
      } else if (sum >= 1) {
        sum -= 1;
      }
      coinsCounter++;
    }
    console.log(coinsCounter);
}

coins(["1.23"])