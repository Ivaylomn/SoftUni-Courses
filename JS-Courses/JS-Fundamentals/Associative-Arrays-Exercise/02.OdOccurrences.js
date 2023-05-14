function solve(str) {
    let myMap = new Map();
    let arr = str.split(' ');
    for (let el of arr) {
        el = el.toLowerCase();
        if (!myMap.has(el)) {
            myMap.set(el, 0);
        }
        myMap.set(el, myMap.get(el) + 1);
    }
    let oddKeys = Array.from(myMap.keys()).filter(x => myMap.get(x) % 2 === 1).join(' ');
    console.log(oddKeys);
}

solve('Java C# Php PHP Java PhP 3 C# 3 1 5 C#');