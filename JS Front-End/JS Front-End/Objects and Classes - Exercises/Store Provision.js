function storeStocking(arrayOne, arrayTwo) {
  //arrayOne.concate(arrayTwo);
  let arr = [...arrayOne, ...arrayTwo];

  let products = arr.reduce((acc, curr, i) => {
    if (i % 2 !== 0) {
      return acc;
    }
    if (!acc.hasOwnProperty(curr)) {
      acc[curr] = 0;
    }
    acc[curr] += Number(arr[i + 1]);
    return acc;
  }, {});

  Object.entries(products).forEach(([product, amount]) =>
    console.log(`${product} -> ${amount}`)
  );
}