function solve(params) {
    let input = String(params);
    let evenSum = 0;
    let oddSum = 0;
    for (let i = 0; i < input.length; i++) {
      const element = Number(input[i]);
  
      if (element % 2 === 0) {
        evenSum += element;
      } else if (element % 2 !== 0) {
        oddSum += element;
      }
    }
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
  }
  solve(1000435);