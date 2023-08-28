function solve(input){
    const employees = input.reduce((acc,curr) => {
        acc[curr] = curr.length;
        return acc;
    }, {})
    

Object.entries(employees).forEach(([name, number]) => {
    console.log(`Name: ${name} -- Personal Number: ${number}`);
})


}

solve([
'Silas Butler',
'Adnaan Buckley',
'Juan Peterson',
'Brendan Villarreal'
])