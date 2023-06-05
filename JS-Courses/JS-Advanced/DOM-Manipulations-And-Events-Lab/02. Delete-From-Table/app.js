function deleteByEmail() {
    //Select with QuearySelector by name atribut->
    //const inputEmailElement = document.querySelector('input[name="email"]');

    const inputEl = document.getElementsByName('email')[0].value;
    const trElements = Array.from(document.querySelectorAll('tbody tr'));
    let result = '';
    for (const el of trElements) {
        if (el.children[1].textContent === inputEl) {
            el.remove();
            result = 'Delete.';
            break;
        } else {
            result = 'Not found.'
        }
    }
    document.getElementById('result').textContent = result;
}