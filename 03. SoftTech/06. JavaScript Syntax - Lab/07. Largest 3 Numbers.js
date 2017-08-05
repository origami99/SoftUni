function solve(input) {
    let nums = input
        .map(Number)
        .sort(function (a, b) {
            return b - a
        });

    let counter = 0;
    for (let num of nums) {
        counter++;

        console.log(num);

        if (counter === 3) {
            return;
        }
    }
}