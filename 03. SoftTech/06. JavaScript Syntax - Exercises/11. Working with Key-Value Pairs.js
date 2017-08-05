function solve(input) {
    let dict = new Map;

    for (let i = 0; i < input.length - 1; i++) {
        let key = input[i].split(' ')[0];
        let value = input[i].split(' ')[1];

        dict[key] = value;
    }

    let searched = input[input.length - 1];

    if(searched in dict){
        console.log(dict[searched]);
    }
    else{
        console.log("None");
    }
}