function orders(product, productQuantity) {
    let price = 0;
    let sum = 0;
    switch (product) {
      case "coffee":
        price = 1.5;
        sum += price * productQuantity;
        break;
      case "water":
        price = 1.0;
        sum += price * productQuantity;
        break;
      case "coke":
        price = 1.4;
        sum += price * productQuantity;
        break;
      case "snacks":
        price = 2.00;
        sum += price * productQuantity;
        break;
      default:
        break;
    }
    console.log(sum.toFixed(2));
  }
  orders("water", 5);