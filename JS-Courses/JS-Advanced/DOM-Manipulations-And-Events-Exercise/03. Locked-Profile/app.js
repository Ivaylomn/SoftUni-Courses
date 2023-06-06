function lockedProfile() {
    const buttons = document.querySelectorAll('.profile button');
    
    for (const btn of buttons) {
        btn.addEventListener('click', showMore);
    }

    function showMore(e) {
        const currentTarget = e.target.parentElement.querySelector('div');
        if (e.target.textContent == 'Show more') {
            e.target.textContent = 'Hide it';
            currentTarget.style.display = 'block';
        } else {
            e.target.textContent = 'Show more';
            currentTarget.style.display = 'none';
        }
    }
}