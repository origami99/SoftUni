function solve(input) {
    for(let json of input){
        let obj = JSON.parse(json);

        console.log(`Name: ${obj.name}`);
        console.log(`Age: ${obj.age}`);
        console.log(`Date: ${obj.date}`);
    }
}