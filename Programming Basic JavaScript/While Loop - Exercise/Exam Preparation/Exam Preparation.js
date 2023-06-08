function examPrep(input){

    let index = 0;
    let maxFails = Number(input[index]);
    index++;
    let allScores = 0;
    let jobsCounter = 0;
    let lastJob = "";
    let fails = 0;
    let command = input[index];
    index++;
  
    while (command !== "Enough") {
      let jobName = String(command);
      lastJob = jobName;
      jobsCounter++;
  
      command = input[index];
      index++;
  
      let grade = Number(command);
      allScores += grade;
  
      if (grade <= 4) {
        fails++;
      }
      if (fails >= maxFails) {
        console.log(`You need a break, ${fails} poor grades.`);
        break;
      }
      command = input[index];
      index++;
    }
    let averageScore = (allScores / jobsCounter).toFixed(2);
  
    if (fails < maxFails) {
      console.log(`Average score: ${averageScore}`);
      console.log(`Number of problems: ${jobsCounter}`);
      console.log(`Last problem: ${lastJob}`);
    }
}

examPrep(["2", "Income", "3", "Game Info", "6", "Best Player", "4"])