function solve(input) {
    let arr = input[0].split(' ').map(Number);
    let len = arr.length;

    let left = arr.slice(0, len / 4).reverse();
    let middle = arr.slice(len / 4, len / 2 + len / 4);
    let right = arr.slice(len / 2 + len / 4, len).reverse();

    for(let i = 0; i < left.length; i++){
        middle[i] += left[i];
    }
    for(let i = 0; i < right.length; i++){
        middle[i + len / 4] += right[i];
    }

    console.log(middle.join(' '));
}
