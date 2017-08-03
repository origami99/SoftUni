function solve(input) {
    let phonebook = new Map;

    for(let i = 0; i < input.length - 1; i++){
        let data = input[i].split(' ');
        let action = data[0];
        let name = data[1];

        if(action === "A"){
            let phone = data[2];

            phonebook.set(name, phone);
        }
        else{
            if(phonebook.has(name)){
                console.log(name + " -> " + phonebook.get(name));
            }
            else{
                console.log(`Contact ${name} does not exist.`)
            }
        }
    }
}