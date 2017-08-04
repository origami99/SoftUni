function solve(input) {
    let x = Number(input[0]);
    let y = Number(input[1]);
    let z = Number(input[2]);

    console.log([x, y, z].filter(x => x < 0).length % 2 === 0 ? "Positive" : "Negative");
}