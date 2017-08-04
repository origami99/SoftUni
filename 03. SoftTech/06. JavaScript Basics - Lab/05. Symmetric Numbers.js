function solve(input) {
    let n = input[0];

    let symmetricNums = "";

    for(let i = 1; i <= n; i++){
        let leftPart = "";
        let rightPart = "";
        let curr = i.toString();
        let len = curr.length;

        if(i <= 9){
            symmetricNums += curr + " ";
            continue;
        }

        leftPart = curr.substring(0, len / 2);

        len += len % 2 === 0 ? 0 : 1 ;
        rightPart = curr.substring(len / 2);
        rightPart = getReversed(rightPart);

        if(leftPart === rightPart){
            symmetricNums += curr + " ";
        }
    }

    console.log(symmetricNums);

    function getReversed(str) {
        let reversed = "";

        for(let i = str.length - 1; i >= 0; i--){
            reversed += str[i];
        }

        return reversed;
    }
}