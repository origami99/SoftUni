function solve(input) {
    let text = input[0].toLowerCase();
    let word = input[1].toLowerCase();

    let counter = 0;
    let index = text.indexOf(word);

    while(index !== -1){
        counter++;
        index = text.indexOf(word, index + 1);
    }

    console.log(counter);
}