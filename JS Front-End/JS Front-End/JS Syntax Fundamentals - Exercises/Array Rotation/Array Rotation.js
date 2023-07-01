function solve(arr, count) {
    for (let i = 1; i <= count; i++) {
      let firstEl = arr[0];
      arr.shift();
      arr.push(firstEl);
    }
    console.log(arr.join(' '));
  }
  solve([51, 47, 32, 61, 21], 2);