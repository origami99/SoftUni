function solve(input) {
    let n = input[0];

    console.log(fibonacci(n));

    function fibonacci(n) {
        let a = 0;
        let b = 1;
        let temp = null;

        for(let i = 0; i < n; i++){
            temp = a;
            a = b;
            b = temp + a;
        }

        return b;
    }
}