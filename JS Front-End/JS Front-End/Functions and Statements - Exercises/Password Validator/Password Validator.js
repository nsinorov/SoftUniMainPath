function solve(params) {
    let digitCount = 0;
    let isValid = true;
  
    if (params.length < 6 || params.length > 10) {
      console.log(`Password must be between 6 and 10 characters`);
      isValid = false;
    }
    for (let char of params) {
      char = Number(char);
      if (isDigit(char)) {
        digitCount++;
      }
    }
    for (let char of params) {
      if (!isLetter(char) && !isDigit(char)) {
        console.log(`Password must consist only of letters and digits`);
        isValid = false;
        break;
      }
    }
    if (digitCount < 2) {
      console.log(`Password must have at least 2 digits`);
      isValid = false;
    }
    if (isValid) {
      console.log(`Password is valid`);
    }
    function isDigit(char) {
      return char >= 0 && char <= 9;
    }
    function isLetter(char) {
      return (char >= "a" && char <= "z") || (char >= "A" && char <= "Z");
    }
  }
  solve("MyPass123");