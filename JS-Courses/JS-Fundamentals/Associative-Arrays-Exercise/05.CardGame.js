function cardGames(input) {
    const colors = {
        'S': 4,
        'H': 3,
        'D': 2,
        'C': 1
    };
    const cards = {
        'A': 14,
        'K': 13,
        'Q': 12,
        'J': 11
    };
    let obj = {};
    for (const el of input) {
        let [name, hand] = el.split(': ');
        if (!obj.hasOwnProperty(name)) {
            obj[name] = [];
        }
        obj[name].push(...hand.split(', '));
    }
    for (const key in obj) {
        let handArr = new Set(obj[key]);
        let total = 0;
        for (const el of handArr) {
            let elements = el.split('');
            let color = elements.pop();
            let cardNum = elements.join('');
            if (isNaN(cardNum)) {
                cardNum = cards[cardNum];
            }
            total += colors[color] * Number(cardNum);
        }
        console.log(`${key}: ${total}`);
    }
}

cardGames([
    'Peter: 2C, 4H, 9H, AS, QS',
    'Tomas: 3H, 10S, JC, KD, 5S, 10S',
    'Andrea: QH, QC, QS, QD',
    'Tomas: 6H, 7S, KC, KD, 5S, 10C',
    'Andrea: QH, QC, JS, JD, JC',
    'Peter: JD, JD, JD, JD, JD, JD'
]);