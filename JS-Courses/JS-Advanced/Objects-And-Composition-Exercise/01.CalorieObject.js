function calorieObject(arr) {
    let productInfo = {};
    for (let i = 0; i < arr.length; i += 2) {
        let food = arr[i];
        let caloeris = Number(arr[i + 1]);
        productInfo[food] = caloeris;
    }
    console.log(productInfo);
}
calorieObject(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);
calorieObject(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']);