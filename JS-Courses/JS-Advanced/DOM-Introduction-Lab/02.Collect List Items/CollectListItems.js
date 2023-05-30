function extractText() {
    let elemets = Array.from(document.getElementById('items').children);
    for (const el of elemets) {
        document.getElementById('result').textContent += el.textContent + '\n';
    }
    //let elementsWithSelector = document.querySelectorAll('#items li');
    //console.log(elementsWithSelector[1].textContent);
}