function solve(input) {
    let num = input[0];

    let reversed = getReversed(num);
    console.log(reversed);

    function getReversed(num) {
        let reversed = "";

        for(let i = num.length - 1; i >= 0; i--){
            reversed += num[i];
        }

        return reversed;
    }
}
