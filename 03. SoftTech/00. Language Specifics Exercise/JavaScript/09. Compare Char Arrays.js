function solve(input) {
    let arr1 = input[0].split(" ");
    let arr2 = input[1].split(" ");

    let minLen = Math.min(arr1.length, arr2.length);

    for(let i = 0; i < minLen; i++){
        if(arr1[i] > arr2[i]){
            console.log(arr2.join(''));
            console.log(arr1.join(''));
            return;
        }
        else if(arr1[i] < arr2[i]){
            console.log(arr1.join(''));
            console.log(arr2.join(''));
            return;
        }
    }

    if(arr1.length > arr2.length){
        console.log(arr2.join(''));
        console.log(arr1.join(''));
    }
    else{
        console.log(arr1.join(''));
        console.log(arr2.join(''));
    }
}