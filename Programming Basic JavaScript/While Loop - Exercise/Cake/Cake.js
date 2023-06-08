function cake(input){
    
    let w = Number(input[0]);
    let h = Number(input[1]);

    let cakeSpace = w * h;
    let index = 2;

    let command = input[index];
    index++;

    
    while (cakeSpace >= 0) {
        if (command === "STOP") {
          break;
        }
        let pieces = Number(command);
        cakeSpace -= pieces;
        command = input[index];
        index++;
      }
    
      let difference = Math.abs(cakeSpace);
    
      if (cakeSpace < 0) {
        console.log(`No more cake left! You need ${difference} pieces more.`);
      } else {
        console.log(`${cakeSpace} pieces are left.`);
      }
}

cake(["10", "10", "20", "20", "20", "20", "21"]);