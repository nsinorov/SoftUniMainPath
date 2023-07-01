function solve(params) {
    params = params.split(" ");
    for (const element of params) {
      if (
        element.startsWith("#") &&
        element.length > 1 &&
        isLettersOnly(element.substring(1))
      ) {
        let result = element.substring(1);
        console.log(result);
      }
    }
    function isLettersOnly(str) {
      return str.split("").every((char) => isLetter(char));
    }
    function isLetter(char) {
      return (char >= "a" && char <= "z") || (char >= "A" && char <= "Z");
    }
  }
  solve("Nowadays everyone uses # to tag a #special word in #socialMedia");