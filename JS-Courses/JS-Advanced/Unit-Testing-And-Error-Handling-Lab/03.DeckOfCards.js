function deckOfCards(arr) {
    let result = [];
    for (const el of arr) {
        const suit = el.slice(-1);
        const face = el.slice(0, -1);
        try {
            result.push(playingCards(face, suit));
        } catch (error) {
            console.log('Invalid card: ' + el);
            return;
        }
    }
    console.log(result.join(', '));
    function playingCards(face, suit) {
        const faceArray = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
        const suits = {
            'S': '\u2660',
            'H': '\u2665',
            'D': '\u2666',
            'C': '\u2663'
        };
        if (!faceArray.includes(face) || !Object.keys(suits).includes(suit)) {
            throw Error('Invalid error!');
        }
        return {
            face,
            suit: suits[suit],
            toString() {
                return  this.face + this.suit;
            }
        }
    }
}