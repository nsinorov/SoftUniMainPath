function solve(params, text) {
    let symbolLength = 0;
    let arr = text.split(" ");
    let paramsArr = params.split(", ");
  
    for (let k = 0; k < paramsArr.length; k++) {
      let searchedWord = paramsArr[k];
      for (let i = 0; i < arr.length; i++) {
        let element = arr[i];
        if (element.includes("*")) {
          symbolLength = element.length;
          if (searchedWord.length === symbolLength) {
            text = text.replace(element, searchedWord);
          }
        }
      }
    }
    console.log(text);
  }
  solve(
    "great, learning",
    "softuni is ***** place for ******** new programming languages"
  );