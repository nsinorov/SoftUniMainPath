function solve(params) {
    const pattern = /\w+/g;
    const words = [];
    let match = pattern.exec(params);
  
    while (match != null) {
      words.push(match[0]);
      match = pattern.exec(params);
    }
  
    upperCaseWords = words.map((word) => word.toUpperCase());
    console.log(upperCaseWords.join(", "));
  }
  solve("Hi, how are you?");