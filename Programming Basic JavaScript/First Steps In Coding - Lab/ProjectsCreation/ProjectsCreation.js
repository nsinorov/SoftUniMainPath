function projectCreation(input)
{
let oneProject = 3;
let architectName = input[0];

let result = oneProject * input[1];

console.log(`The architect ${architectName} will need ${result} hours to complete ${input[1]} project/s.`);

}

projectCreation(["George", 4]);