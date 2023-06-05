function addItem() {
    const inputElement = document.getElementById('newItemText');
    const ulElements = document.getElementById('items');

    const liElement = document.createElement('li');
    liElement.textContent = inputElement.value;

    const button = document.createElement('a');
    button.href = '#';
    button.textContent = '[Delete]';
    button.addEventListener('click', removeElement);

    liElement.appendChild(button);
    ulElements.appendChild(liElement);

    inputElement.value = '';

    function removeElement() {
        liElement.remove();
    }
}