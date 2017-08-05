function solve(input) {
    let list = [];

    for (let i = 0; i < input.length; i++) {
        let command = input[i].split(' ');

        switch (command[0]) {
            case "add":
                let num = command[1];
                list.push(num);
                break;
            case "remove":
                let index = command[1];
                list.splice(index, 1);
                break;
        }
    }

    return list.join("\n");
}