function solve(text, word) {
    let censored = text.replace(word, repeat(word));
  
    while (censored.includes(word)) {
      censored = censored.replace(word, repeat(word));
    }
    function repeat(word) {
      let result = "";
      for (let i = 0; i < word.length; i++) {
        result += "*";
      }
      return result;
    }
  
    console.log(censored);
  }
solve('A small sentence with some words',
'small')