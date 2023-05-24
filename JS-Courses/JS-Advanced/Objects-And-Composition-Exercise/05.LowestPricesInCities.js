function solve(arr) {
    let productInfo = {};
    for (const el of arr) {
        let [town, product, price] = el.split(' | ');
        price = Number(price);
        if (!productInfo[product]) {
            productInfo[product] = {};
        }
        productInfo[product][town] = price;
    }
    for (const key in productInfo) {
        let sorted = Object.entries(productInfo[key])
        sorted.sort((a,b) => a[1] - b[1]);
        console.log(`${key} -> ${sorted[0][1]} (${sorted[0][0]})`);
    }
}
solve(['Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10']
);