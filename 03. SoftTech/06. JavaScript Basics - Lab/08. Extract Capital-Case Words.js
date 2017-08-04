function solve(input) {
    let text = input.toString();
    let words = text.split(/\W+/g).filter(w => w !== "");

    let capitalizedWords = [];
    for(let word of words){
        if(word === word.toUpperCase()){
            capitalizedWords.push(word);
        }
    }

    console.log(capitalizedWords.join(", "))
}