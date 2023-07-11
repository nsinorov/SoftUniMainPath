function solve(char1, char2) {
    let firstChar = Number(char1.charCodeAt(0));
    let secondChar = Number(char2.charCodeAt(0));
    let result = "";
    if (firstChar < secondChar) {
      for (let i = firstChar + 1; i < secondChar; i++) {
        let currSymbol = String.fromCharCode(i);
        result += `${currSymbol} `;
      }
    } else {
      for (let i = secondChar + 1; i < firstChar; i++) {
        let currSymbol = String.fromCharCode(i);
        result += `${currSymbol} `;
      }
    }
    console.log(result.trimEnd());
  }
  solve("C", "#");