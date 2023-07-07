function signChecker(firstNumber, secondNUmber, thirdNumber) {
    let arr = [];
    arr.push(firstNumber, secondNUmber, thirdNumber);
    let negativeCounter = 0;
    let positiveCounter = 0;
    for (let i = 0; i < arr.length; i++) {
      let element = arr[i];
      if (element < 0) {
        negativeCounter++;
      } else if (element > 0) {
        positiveCounter++;
      }
    }
    if (negativeCounter === 1 || negativeCounter === 3) {
      console.log("Negative");
    } else if (negativeCounter === 2 || positiveCounter === 3) {
      console.log("Positive");
    }
  }
  signChecker(-5, 12, -15);