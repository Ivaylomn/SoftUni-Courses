function solve(n, k) {
    let arr = [1];
    for (let i = 1; i < n; i++) {
        let lastElement = arr.slice(-k);
        let sum = 0;
        for (const el of lastElement) {
            sum += el; 
        }
        arr.push(sum);
    }
    console.log(arr.join(' '));
}

solve(6, 3);
solve(8, 2);