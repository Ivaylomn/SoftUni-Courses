function sumTable() {
    let elements = document.querySelectorAll('tr');
    let sum = 0;
    for (let i = 1; i < elements.length - 1; i++) {
        sum += Number(elements[i].children[1].textContent);
    }
    document.getElementById('sum').textContent = sum;
}