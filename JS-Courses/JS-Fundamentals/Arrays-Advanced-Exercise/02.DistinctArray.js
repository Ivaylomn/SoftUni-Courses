function distinctArray(arr) {
    let newArr = [];
    for (const el of arr) {
        if (!newArr.includes(el)) {
            newArr.push(el);
        }
    }
    console.log(newArr.join(' '));
}

distinctArray([1, 2, 3, 4]);
distinctArray([7, 8, 9, 7, 2, 3, 4, 1, 2]);