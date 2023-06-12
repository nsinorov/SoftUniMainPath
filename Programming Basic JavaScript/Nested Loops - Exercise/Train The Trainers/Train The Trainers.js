function trainTheTrainers(input) {

    let juryCount = Number(input.shift());
    let inpuT = input.shift();
    let gradesCount = 0;
    let sumOfAllGrades = 0;

    while (inpuT != "Finish") {
        let sumOfGrades = 0;
        for (let i = 1; i <= juryCount; i++) {
            let grade = Number(input.shift());
            sumOfGrades += grade;
            gradesCount++;
            sumOfAllGrades += grade;
        }
        let averageForCurrentPresentation = sumOfGrades / juryCount;
        console.log(`${inpuT} - ${averageForCurrentPresentation.toFixed(2)}.`);
        inpuT = input.shift();
    }
    let finalAverageGrade = sumOfAllGrades / gradesCount;
    console.log(`Student's final assessment is ${finalAverageGrade.toFixed(2)}.`)
}
trainTheTrainers(["2",
"While-Loop",
"6.00",
"5.50",
"For-Loop",
"5.84",
"5.66",
"Finish"])

