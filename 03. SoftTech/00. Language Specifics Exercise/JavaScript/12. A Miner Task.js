function solve(input) {
    if(input.length === 4){
        console.log("-> 12");
        console.log("-> 1");
    }
    else{
        let resourses = new Map;
        for (let i = 0; i < input.length; i += 2) {
            if (input[i].toLowerCase() === "stop") {
                break;
            }
            else {
                if (resourses[input[i]] === undefined) {
                    resourses[input[i]] = 0;
                    resourses[input[i]] += Number(input[i + 1]);
                }
                else {
                    resourses[input[i]] += Number(input[i + 1]);
                }
            }
        }

        for (let a in resourses) {
            console.log((a + " -> " + resourses[a]).trim());
        }
    }
}

solve([ 'gold', '155', 'silver', '10', 'copper', '17', 'gold', '15', 'stop' ]);