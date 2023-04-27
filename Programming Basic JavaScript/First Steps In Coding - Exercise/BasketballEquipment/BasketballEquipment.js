function basketballEquip(input)
{
    let priceForOneYear = Number(input[0]);

    let priceForShoes = priceForOneYear - (priceForOneYear * 0.4);
    let priceForEquipment = priceForShoes - (priceForShoes * 0.2);
    let priceForBall = 0.25 * priceForEquipment;
    let priceForAccesories = 0.20 * priceForBall;

    let totalSum = priceForOneYear + priceForShoes + priceForEquipment + priceForBall + priceForAccesories;

    console.log(totalSum);

}

basketballEquip(["550"]);