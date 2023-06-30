function solve(params) {

    let sum = 0;
    let input = String(params);
    for (let index = 0; index < input.length; index++) {
      sum += Number(input[index]);
    }
    console.log(sum);
  }

  solve(245678);