function bestPlayer(input) {

    let playerName = "";
    let goalsMax = 0;
    let hatTrick = false;
    index = 0;

    for (let i = 0; i <= bestPlayer.length * 2; i++)
     {
      let player = String(input[index++]);
      let goals = Number(input[index++]);
  
      if (goals > goalsMax) {
        goalsMax = goals;
        playerName = player;
      }
      if (goals >= 10) {
        break;
      }
    }
    if (goalsMax >= 3) {
      hatTrick = true;
    }
  
    console.log(`${playerName} is the best player!`);
  
    if (hatTrick === true) {
      console.log(`He has scored ${goalsMax} goals and made a hat-trick !!!`);
    } else {
      console.log(`He has scored ${goalsMax} goals.`);
    }
  }
  
  bestPlayer(["Neymar", 2, "Ronaldo", 10, "Messi", 3, "END"]);