function solve(input) {
    let num = Number(input[0]);

    let hex = num.toString(16).toUpperCase();
    let binary = num.toString(2);

    console.log(hex);
    console.log(binary);
}
