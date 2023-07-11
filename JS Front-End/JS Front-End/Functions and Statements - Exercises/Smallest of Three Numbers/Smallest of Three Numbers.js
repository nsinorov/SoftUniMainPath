function smallestNumber(firstNumber, secondNumber, thirdNumber) {
    let arr = [];
    arr.push(firstNumber, secondNumber, thirdNumber);
    let minNumber = Number.MAX_SAFE_INTEGER;
    for (let i = 0; i < arr.length; i++) {
      let element = arr[i];
  
      if (element < minNumber) {
        minNumber = element;
      }
    }
    console.log(minNumber);
  }
  smallestNumber(2, 3, 5);