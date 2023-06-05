function addItem() {
    let li = document.createElement('li');
    li.textContent = document.getElementById('newItemText').value;
    document.getElementById('items').appendChild(li);
    document.getElementById('newItemText').value = '';
}