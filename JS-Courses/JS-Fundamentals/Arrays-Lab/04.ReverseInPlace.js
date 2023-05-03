function reversePlace(array) {
    for (let i = 0; i < array.length / 2; i++) {
        let temp = array[i];
        array[i] = array[array.length - 1 - i];
        array[array.length - 1 - i] = temp;
    }
    console.log(array.join(' '));

    /*Way for solution with nested function->
    for (let i = 0; i < array.length / 2; i++) {
        let lastIndex = array.length - 1 - i
        swapElements(array, i, lastIndex)
    }
    console.log(array.join(' '));
    function swapElements(arr, i, lastIndex){
        let temp = array[i];
        arr[i] = arr[lastIndex];
        arr[lastIndex] = temp;
    }
    */

    /*And shorter way for solution the problem->
    console.log(array.reverse().join(' '));
    */
}

reversePlace(['a', 'b', 'c', 'd', 'e']);
reversePlace(['abc', 'def', 'hig', 'klm', 'nop']);
reversePlace(['33', '123', '0', 'dd']);
