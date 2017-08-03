function solve(input) {
    let bannedWords = input[0].split(', ');
    let text = input[1];

    for (let i = 0; i < bannedWords.length; i++) {
        let regex = new RegExp(bannedWords[i], 'g');
        let stars = new Array(bannedWords[i].length + 1).join('*');
        text = text.replace(regex, stars);
    }

    console.log(text);
}