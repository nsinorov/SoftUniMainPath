function moving(input){

    const width = Number(input[0]);
    const length = Number(input[1]);
    const high = Number(input[2]);
    let space = width * length * high;
    let index = 3;
    let command = input[index];
    index++;
  
    while (space > 0) {
      if (command === "Done") {
        break;
      }
      let packs = Number(command);
      space -= packs;
  
      command = input[index];
      index++;
    }
    let differenece = Math.abs(space);
  
    if (space >= 0) {
      console.log(`${differenece} Cubic meters left.`);
    } else {
      console.log(
        `No more free space! You need ${differenece} Cubic meters more.`
      );
    }
}

moving(["10", "10", "2", "20", "20", "20"])