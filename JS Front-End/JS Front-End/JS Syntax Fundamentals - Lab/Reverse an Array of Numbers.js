function solve(n, params) {
    let arr = [];
    for (let index = 0; index < n; index++) {
      arr.push(params[index]);
    }
    let output = "";
    for (let index = arr.length - 1; index >= 0; index--) {
      output += `${arr[index]} `;
    }
    console.log(output);
  }
  solve(2, [66, 43, 75, 89, 47]);