function solve(arr) {
    class Cat{
        constructor(name, age) {
            this.name = name,
            this.age = age
        }
        meow() {
            console.log(`${this.name}, age ${this.age} says Meow`);
        }
    }
    //let cats = [];
    for (const el of arr) {
        let [name, age] = el.split(' ');
        let cat = new Cat(name, age);
        //cats.push(cat);
        cat.meow();
    }
}

solve(['Mellow 2', 'Tom 5']);