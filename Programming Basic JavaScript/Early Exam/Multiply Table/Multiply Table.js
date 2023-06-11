function multiply(input) {
    const num = "" + input[0];
   
    let firstDig = Number(num[2]);
    let secondDig = Number(num[1]);
    let thirdDig = Number(num[0]);
    for (let a = 1; a <= firstDig; a++) {
      for (let b = 1; b <= secondDig; b++) {
        for (let c = 1; c <= thirdDig; c++) {
          let result = a * b * c;
          console.log(`${a} * ${b} * ${c} = ${result};`);
        }
      }
    }
  }

  multiply(["324"])