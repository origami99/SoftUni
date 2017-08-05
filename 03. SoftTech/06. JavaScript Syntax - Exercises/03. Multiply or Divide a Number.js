function solve(input) {
    let n = Number(input[0]);
    let x = Number(input[1]);

    return x >= n ? (n * x) : (n / x);
}