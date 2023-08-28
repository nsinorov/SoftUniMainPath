function createDictionary(input) {
    let dictionary = {};
  
    //with reduce
    //consat dictionary = input
    //   .map((jasonString) => JSON.parse(jasonString))
    //   .reduce((acc, curr) => {
    //     return {
    //       ...acc,
    //       ...curr,
    //     };
    //   }, {});
  
    //with assign
    input.forEach((jsonString) => {
      const term = JSON.parse(jsonString);
      dictionary = Object.assign(dictionary, term);
    });
  
    Object.entries(dictionary)
      .sort()
      .forEach(([terms, description]) => {
        console.log(`Term: ${terms} => Definition: ${description}`);
      });
  }