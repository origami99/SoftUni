function solve(input) {
    let text = input[0];
    let matches = text.match(/(?:^| )([a-z][a-z0-9\-\\._]+@[a-z0-9\-]+(\.[a-z0-9\-]+)+)/g);

    if(matches !== null){
        for(let m of matches){
            console.log(m.trim());
        }
    }
}