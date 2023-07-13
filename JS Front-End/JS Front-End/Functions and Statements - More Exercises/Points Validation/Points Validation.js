function pointValidation(arr) {
    let x1 = arr.shift()
    let y1 = arr.shift()
    let x2 = arr.shift()
    let y2 = arr.shift();
  
    let x = 0;
    let y = 0;
  
    let first = (Math.sqrt(Math.pow((x1 - x), 2) + Math.pow((y1 - y), 2)));
    let second = (Math.sqrt(Math.pow((x2 - x), 2) + Math.pow((y2 - y), 2)));
    let third = (Math.sqrt(Math.pow((x2 - x1), 2) + Math.pow((y2 - y1), 2)));
  
  console.log(Number.isInteger(first) ? `{${x1}, ${y1}} to {${x}, ${y}} is valid` : `{${x1}, ${y1}} to {${x}, ${y}} is invalid`);
  console.log(Number.isInteger(second) ? `{${x2}, ${y2}} to {${x}, ${y}} is valid` : `{${x2}, ${y2}} to {${x}, ${y}} is invalid`);
  console.log(Number.isInteger(third) ? `{${x1}, ${y1}} to {${x2}, ${y2}} is valid` : `{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
  }
  pointValidation([2, 1, 1, 1]);