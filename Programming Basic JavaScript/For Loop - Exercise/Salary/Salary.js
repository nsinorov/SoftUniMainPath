function salary(input){

    const tabs = Number(input[0]);
  let salary = Number(input[1]);

  for (let index = 2; index < input.length; index++) {
    const currentTab = input[index];
    if (currentTab === 'Facebook') {
      salary -= 150;
    } else if (currentTab === 'Instagram') {
      salary -= 100;
    } else if (currentTab === 'Reddit') {
      salary -= 50;
    }
  }

  if (salary <= 0) {
    console.log('You have lost your salary.');
  } else {
    console.log(salary);
  }
}

salary(["3",
"500",
"Facebook",
"Stackoverflow.com",
"softuni.bg"])
