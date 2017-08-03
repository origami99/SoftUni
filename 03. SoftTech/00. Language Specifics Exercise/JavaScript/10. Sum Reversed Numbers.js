function solve(input) {
    let nums = input[0];

    nums = getReversed(nums).split(' ').map(Number);

    let sum = 0;
    for(let i = 0; i < nums.length; i++){
        sum += nums[i];
    }

    console.log(sum);

    function getReversed(nums) {
        let reversed = "";

        for(let i = nums.length - 1; i >= 0; i--){
            reversed += nums[i];
        }

        return reversed;
    }
}

solve( '123 234 12' );