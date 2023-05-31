function toggle() {
    let spanMoreElement = document.querySelector('.button').textContent;
    if (spanMoreElement === 'More') {
        document.getElementById('extra').style.display = 'block';
        document.querySelector('.button').textContent = 'Less';
    } else {
        document.getElementById('extra').style.display = 'none';
        document.querySelector('.button').textContent = 'More';
    }
}