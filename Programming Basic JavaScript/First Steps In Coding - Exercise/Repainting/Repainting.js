function repainting(input)
{
    let coveredNaylon = 1.50 * (Number(input[0]) + 2); // for sq m
    let paint = 14.50 * (Number(input[1]) + (0.1 * Number(input[1]))) ; // for l.
    let thinner = 5.00 * (Number(input[2])); // for l.
    let bag = 0.40;

    let sumForMaterials = coveredNaylon + paint + thinner + bag;
    let sumForWorkers = Number(input[3]) * (sumForMaterials * 0.3);

    console.log(sumForMaterials + sumForWorkers);
}

repainting(["10","11","4","8"]);