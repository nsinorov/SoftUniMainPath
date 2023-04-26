function petShop(input) 
{
    let onePackageDogFood = 2.50;
    let onePackageCatFood = 4;

    console.log(`${onePackageDogFood * input[0] + onePackageCatFood * input[1]}`);

}

petShop([5, 4]);