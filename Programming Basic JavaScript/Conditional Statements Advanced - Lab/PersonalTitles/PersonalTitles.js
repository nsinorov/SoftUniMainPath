function personalTitles(input){

    let age = Number(input.shift());
    let gender = input.shift();
    let isOfAge = age < 16;

    if(gender === "f"){
        if(isOfAge){
            console.log("Miss");
        }
        else{
            console.log("Ms.");
        }
    }
    else{
        if(isOfAge){
            console.log("Master");
        }
        else{
            console.log("Mr.");
        }
    }
}

personalTitles(["12",
"f"])

personalTitles(["17",
"m"])

personalTitles(["25",
"f"])

personalTitles(["13.5",
"m"])


