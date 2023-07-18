function solve(name, lastName, hairColor){

    let obj = {
        name,
        lastName,
        hairColor,
    };

    console.log(JSON.stringify(obj));
}

solve('George', 'Jones',
'Brown')