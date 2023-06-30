function solve(year){

     if (year % 4 === 0 && year % 100 !== 0) 
     {
        console.log('yes');
     }
     else if(year % 400 === 0){
        console.log('yes');
     }
     else {
        console.log('no');
     }
}

solve(4)