function solve(input) {
    let dict = new Map;

    for (let i = 0; i < input.length - 1; i++) {
        let key = input[i].split(' ')[0];
        let value = input[i].split(' ')[1];

        if (!(key in dict)){
            dict[key] = [];
        }

        dict[key].push(value);
    }

    let searched = input[input.length - 1];

    if(searched in dict){
        console.log(dict[searched].join('\n'));
    }
    else{
        console.log("None");
    }
}

solve([ 'key value', 'key eulav', 'test tset', 'key' ]);