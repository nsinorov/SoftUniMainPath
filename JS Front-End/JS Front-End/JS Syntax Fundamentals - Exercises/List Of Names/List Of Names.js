function solve(params) {
    params.sort(function (a, b) {
      return a.localeCompare(b, undefined, { sensitivity: "base" });
    });
  
    for (let i = 0; i < params.length; i++) {
      let element = params[i];
      console.log(`${i + 1}.${element}`);
    }
  }
  solve(["John", "Bob", "Christina", "Ema"]);