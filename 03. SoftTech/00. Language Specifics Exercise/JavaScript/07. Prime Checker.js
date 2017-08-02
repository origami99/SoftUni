
function solve(input) {

    let num = Number(input[0]);

    console.log(isPrime(num) ? "True" : "False");

    function isPrime(num) {
        switch(num) {
            case 0:
                return false;
                break;
            case 1:
                return false;
                break;
            case 2:
                return true;
                break;
        }

        for(let i = 2; i <= Math.sqrt(num); i++) {
            if (num % i === 0) {
                return false;
            }
        }

        return true;
    }
}
