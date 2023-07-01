function solve(searchedWord, params) {
    let paramsArr = params.toLowerCase().split(" ");
  
    if (paramsArr.includes(searchedWord.toLowerCase())) {
      console.log(searchedWord);
    } else {
      console.log(`${searchedWord} not found!`);
    }
  }
  solve("javascript", "Javascript is the best programming language");