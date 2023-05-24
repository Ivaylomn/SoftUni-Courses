function sotreCatalogue(arr) {
    let obj = {};
    for (const el of arr) {
        let [product, price] = el.split(' : ');
        price = Number(price);
        let firstIndex = product[0];
        if (!obj[firstIndex]) {
            obj[firstIndex] = {};
        }
        obj[firstIndex][product] = price;
    }
    let sortedKey = Object.keys(obj).sort((a,b) => a.localeCompare(b))
    for (const key of sortedKey) {
        let products = Object.entries(obj[key]).sort((a,b) => a[0].localeCompare(b[0]));
        console.log(key);
        for (const el of products) {
            console.log(`  ${el[0]}: ${el[1]}`);
        }
    }
}
console.log(sotreCatalogue(['Appricot : 20.4',
'Fridge : 1500',
'TV : 1499',
'Deodorant : 10',
'Boiler : 300',
'Apple : 1.25',
'Anti-Bug Spray : 15',
'T-Shirt : 10']
));