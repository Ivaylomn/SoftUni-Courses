function reverseArray(n, arr) {
    let newArr = [];
    for (let i = 0; i < n; i++) {
        newArr[i] = arr[i];
    }

    let output = '';
    for(let i = newArr.length - 1; i >= 0; i--) {
        output += newArr[i] + ' ';
    }

    console.log(output);

    //And other way to solution our problem->
    // for (let i = n - 1; i >= 0; i--) {
    //     newArr[i] = arr[i];
    // }
    // console.log(newArr.join(' '));

    //And one more way for solution->
    //The shortest way for solution->
    //console.log(arr.slice(0, n).reverse().join(' '));
}

reverseArray(3, [10, 20, 30, 40, 50]);
reverseArray(4, [-1, 20, 99, 5]);
reverseArray(2, [66, 43, 75, 89, 47]);