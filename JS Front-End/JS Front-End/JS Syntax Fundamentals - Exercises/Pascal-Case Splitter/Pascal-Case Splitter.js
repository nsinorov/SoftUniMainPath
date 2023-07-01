function solve(params) {
    let arr = [];
  
    for (let i = 0; i < params.length; i++) {
      if (i === 0) {
        arr.push(params[i]);
        i++;
      }
      let char = params[i];
      if (char !== char.toUpperCase()) {
        arr += `${char}`;
      } else if (char === char.toUpperCase()) {
        arr += `, ${char}`;
      }
    }
    console.log(arr.trimEnd());
  }
  solve("SplitMeIfYouCanHaHaYouCantOrYouCan");