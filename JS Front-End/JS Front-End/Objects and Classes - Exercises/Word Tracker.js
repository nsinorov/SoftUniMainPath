function findeOccurrences(input) {
    const [searchedWords, ...words] = input;
    const wordOccurrences = searchedWords.split(" ").reduce((acc, curr) => {
      acc[curr] = 0;
      return acc;
    }, {});
  
    words.forEach((word) => {
      if (wordOccurrences.hasOwnProperty(word)) {
        wordOccurrences[word]++;
      }
    });
  
    Object.entries(wordOccurrences)
      .sort(([, a], [, b]) => b - a)
      .forEach(([word, occurrences]) => {
        console.log(`${word} - ${occurrences}`);
      });
  }