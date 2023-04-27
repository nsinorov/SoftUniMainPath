function foodDelivery(input)
{
    let chickenMenu = 10.35 * Number(input[0]);
    let fishMenu = 12.40 * Number(input[1]);
    let vegeterianMenu = 8.15 * Number(input[2]);

    let sumAllMenus = chickenMenu + fishMenu + vegeterianMenu;
    
    let priceForDessert = 0.2 * sumAllMenus;

    let delivery = 2.50;

    let totalSum = sumAllMenus + priceForDessert + delivery;

    console.log(totalSum);
}
foodDelivery(["9 ",
"2 ",
"6 "]
);