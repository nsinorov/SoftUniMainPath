function suppliesForSchool(input)
{
    let packOfPens = 5.80 * Number(input[0]);
    let packOfMarkers = 7.20 * Number(input[1]);
    let detergentForLiter = 1.20 * Number(input[2]);

    let sumForAllMaterials = packOfPens + packOfMarkers + detergentForLiter;

    let discount = Number(input[3] / 100);

    let priceWithDiscount = sumForAllMaterials - (sumForAllMaterials * discount);

    console.log(priceWithDiscount);
}

suppliesForSchool(["2","3","4","25"]);