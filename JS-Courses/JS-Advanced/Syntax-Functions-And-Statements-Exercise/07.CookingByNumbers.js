function cookingByNumbers(number, ...operation){
    number = Number(number);
    for (const el of operation) {
        switch (el) {
            case 'chop':
                console.log(number /= 2);
                break;
            case 'dice':
                console.log(number = Math.sqrt(number));
                break;
            case 'spice':
                console.log(number += 1);
                break;
            case 'bake':
                console.log(number *= 3);
                break;
            case 'fillet':
                console.log(number -= number * 0.20);
                break;
        }
    }
}
cookingByNumbers('32', 'chop', 'chop', 'chop', 'chop', 'chop');
cookingByNumbers('9', 'dice', 'spice', 'chop', 'bake', 'fillet');