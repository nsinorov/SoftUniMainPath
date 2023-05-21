function animalType(input){

    let typeOfAnimal = input.shift();

    switch(typeOfAnimal){
        case "dog":
            console.log("mammal");
            break;
            case "crocodile":
             case "tortoise":
             case "snake":
                console.log("reptile");
                break;
            default: 
            console.log("unknown");
            break;
    }
}

animalType(["dog"])
animalType(["snake"])
animalType(["cat"])
