function carWash(params){

    let cleanPercent = 0;

    for (let index = 0; index < params.length; index++) {
        
        const command = params[index];

        if(command === "soap"){
            cleanPercent += 10;
        }
        else if(command === 'water'){
            cleanPercent += cleanPercent * 0.2;
        }
        else if(command === 'vacuum cleaner'){
            cleanPercent += cleanPercent * 0.25;
        }
        else if(command === 'mud'){
            cleanPercent -= cleanPercent * 0.1;
        }
    }


    return `The car is ${cleanPercent.toFixed(2)}% clean.`;
}

console.log(carWash(['soap', 'soap', 'vacuum cleaner', 'mud', 'soap', 
'water']
));
