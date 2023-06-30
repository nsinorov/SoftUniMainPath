function solve(params) {
    let input = String(params);
    let sum = 0;
    let isSame = true;
    for (let index = 0; index < input.length; index++) {
      sum += Number(input[index]);
      if (index < input.length - 1) {
        let currNumber = Number(input[index]);
        let nextNumber = Number(input[index + 1]);
        if (currNumber !== nextNumber) {
          isSame = false;
        }
      }
    }
    console.log(isSame);
    console.log(sum);
  }
  solve(2222222);