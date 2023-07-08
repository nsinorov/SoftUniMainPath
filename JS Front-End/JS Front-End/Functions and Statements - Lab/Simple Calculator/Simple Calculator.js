function simpleCalculator(firstNumber, secondNumber, operator) {
    let result = 0;
    switch (operator) {
      case "multiply":
        result = firstNumber * secondNumber;
        break;
      case "divide":
        result = firstNumber / secondNumber;
        break;
      case "add":
        result = firstNumber + secondNumber;
        break;
      case "subtract":
        result = firstNumber - secondNumber;
      default:
        break;
    }
    console.log(result);
  }
  simpleCalculator(5, 5, "multiply");