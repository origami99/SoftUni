function solve(input) {
    let len = Number(input[0]);
    let arr = new Array(len).fill(0);

    for (let i = 1; i < input.length; i++) {
        let index = Number(input[i].split(" - ")[0]);
        let value = Number(input[i].split(" - ")[1]);

        arr[index] = value;
    }

    return arr.join("\n");
}