function solve(nums) {
    nums.split(' ').map(Number);

    let num1 = nums[0];
    let num2 = nums[1];
    let num3 = nums[2];

    if(num1 + num2 === num3){
        console.log(`${Math.min(num1, num2)} + ${Math.max(num1, num2)} = ${num3}`);
    }
    else if(num1 + num3 === num2){
        console.log(`${Math.min(num1, num3)} + ${Math.max(num1, num3)} = ${num2}`);
    }
    else if(num2 + num3 === num1){
        console.log(`${Math.min(num2, num3)} + ${Math.max(num2, num3)} = ${num1}`);
    }
    else{
        console.log("No");
    }
}
