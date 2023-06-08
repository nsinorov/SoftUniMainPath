function graduation(input) {
    let index = 0;
    let name = input[index];
    index++;
    let gradeSum = 0;
    let countOfClass = 0;
    let grade = Number(input[index]);
    index++;
    let failsCounter = 0;
  
    while (countOfClass < 12) {
     
  
      if (grade < 4) {
        failsCounter++;
        grade = Number(input[index]);
        index++;
        continue;
      }
  
      countOfClass++;
  
      if (failsCounter > 1) {
        console.log(`${name} has been excluded at ${countOfClass} grade`);
        break;
      }
  
      gradeSum += grade;
      grade = Number(input[index]);
      index++;
    }
  
    let realGrade = (gradeSum / countOfClass).toFixed(2);
  
    if (failsCounter <= 1) {
      console.log(`${name} graduated. Average grade: ${realGrade}`);
    }
  }
  graduation(["Mimi", "5", "6", "5", "6", "5", "6", "6", "2", "3"]);