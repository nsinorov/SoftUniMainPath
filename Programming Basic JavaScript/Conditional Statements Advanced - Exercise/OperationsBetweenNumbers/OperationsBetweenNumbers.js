function opsBetweemNums(input){

    let num1 = Number(input.shift());
    let num2 = Number(input.shift());
    let opeation = input.shift()

    if (opeation == '+' || opeation == '-' || opeation == '*')
            {
                let result = 0;
                let evenOrOdd = "even";

                switch (opeation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                        case '-':
                        result = num1 - num2;
                        break;
                        default:
                      result =  num1* num2;
                        break;
                }
            
        
                if( result %2!= 0)
                {
                    evenOrOdd = "odd";
                }

                console.log(`${num1} ${opeation} ${num2} = ${result} - ${evenOrOdd}`);
            }
            else
                {
                    if (num2 == 0)
                    {
                        console.log(`Cannot divide ${num1} by zero`);
                    }
                    else if (opeation == '/')
                    {
                        let  result = 1.0*num1 / num2;
                        console.log(`${num1} / ${num2} = ${result.toFixed(2)}`);
                    }
                    else
                    {
                        console.log(`${num1} % ${num2} = ${num1 % num2}`);
                    }
                }

}

opsBetweemNums(["10",
"12",
"+"])

opsBetweemNums(["10",
"1",
"-"])

opsBetweemNums(["7",
"3",
"*"])

opsBetweemNums(["123",
"12",
"/"])

opsBetweemNums(["10",
"3",
"%"])

opsBetweemNums(["112",
"0",
"/"])

opsBetweemNums(["10",
"0",
"%"])

