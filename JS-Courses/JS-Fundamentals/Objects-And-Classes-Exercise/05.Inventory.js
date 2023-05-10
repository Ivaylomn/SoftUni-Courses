function inventory(arr) {
    let store = [];
    for (const el of arr) {
        let [heroName, level, items] = el.split(' / ');
        items = items.split(', ').sort((a, b) => a.localeCompare(b)).join(', ');
        let currentObj = {
            heroName,
            level,
            items
        };
        store.push(currentObj);
    }
    store
    .sort((a, b) => a.level - b.level)
    .forEach(obj => {
        console.log(`Hero: ${obj.heroName}`);
        console.log(`level => ${obj.level}`);
        console.log(`items => ${obj.items}`);
    });
}

inventory([
    "Isacc / 25 / Apple, GravityGun",
    "Derek / 12 / BarrelVest, DestructionSword",
    "Hes / 1 / Desolator, Sentinel, Antara"
]);