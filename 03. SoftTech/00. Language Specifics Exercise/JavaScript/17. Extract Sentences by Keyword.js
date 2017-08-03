function solve(input) {
    let word = input[0];
    let text = input[1];

    let sentences = text.split(/[!\\?\\.]/);
    let pattern = "[^A-Za-z]" + word + "[^A-Za-z]";

    for (let s of sentences) {
        if (s.match(pattern) !== null) {
            console.log(s);
        }
    }
}