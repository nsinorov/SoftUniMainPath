function findeOccurrences(input) {
    const lowerCase = input.toLowerCase().split(" ");
    const wordOccurrences = lowerCase.reduce((acc, curr) => {
      acc[curr] = 0;
      return acc;
    }, {});
  
    lowerCase.forEach((word) => {
      if (wordOccurrences.hasOwnProperty(word)) {
        wordOccurrences[word]++;
      }
    });
  
    let arrayOccurrences = [];
    Object.entries(wordOccurrences)
      .sort(([, a], [, b]) => b - a)
      .forEach(([word, occurrences]) => {
        if (occurrences % 2 === 1) {
          arrayOccurrences.push(word);
        }
      });
    console.log(arrayOccurrences.join(" ").trimEnd());
  }