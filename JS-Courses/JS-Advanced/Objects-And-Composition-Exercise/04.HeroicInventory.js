function heroicInventory(arr) {
    let arrOfHeroic = [];
    for (const el of arr) {
        let [name, level, items] = el.split(' / ');
        let curentItems = items ? items.split(', ') : [];
        level = Number(level);
        let obj = {
            name,
            level,
            items: curentItems
        }
        arrOfHeroic.push(obj);
    }
    return JSON.stringify(arrOfHeroic);
}
console.log(heroicInventory(['Isacc / 25 / ',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara']
));
console.log(heroicInventory(['Jake / 1000 / Gauss, HolidayGrenade']));