function solve(input) {
    let num = input[0];

    let digitName = getLastDigitName(num);
    console.log(digitName);

    function getLastDigitName(num) {
        let names = "zero one two three four five six seven eight nine".split(" ");
        let lastDigit = Number(num.substr(num.length - 1));

        return names[lastDigit];
    }
}
