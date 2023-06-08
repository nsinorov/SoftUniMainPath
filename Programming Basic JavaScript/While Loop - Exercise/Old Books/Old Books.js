function oldBooks(input){

    let favouriteBook = input[0];
    let counter = 0;
    let input1 = input[1];
    let index = 2;

    while(input1 !== "No More Books")
    {
        if(input1 === favouriteBook){
            break;
        }
        counter++
        input1 = input[index];
        index++;
    }

    if(input1 === favouriteBook){
        console.log(`You checked ${counter} books and found it.`);

    }
    else{
        console.log(`The book you search is not here!`);
        console.log(`You checked ${counter} books.`);
    }
}

oldBooks(["Troy", "Stronger", "Life Style", "Troy", "The Spot", "Hunger Games", "Harry Poter", "Torronto", "Spotify", "No More Books"])