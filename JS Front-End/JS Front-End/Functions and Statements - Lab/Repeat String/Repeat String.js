function repeatString(text, count){

    let copy = "";

    for (let index = 1; index <= count; index++) {
       
       copy += text;
    }

    console.log(copy);

}

repeatString("abc", 3 )