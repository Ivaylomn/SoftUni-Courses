function loadCommits() {
    const username = document.getElementById('username').value;
    const repo = document.getElementById('repo').value;
    const listElement = document.getElementById('commits');
    
    const url = `https://api.github.com/repos/${username}/${repo}/commits`;
    fetch(url)
    .then(res => {
        if (res.ok == false) {
            throw new Error(`Error: ${res.status} (Not Found)`);
        }
        return res.json();
    })
    .then(handleResponse)
    .catch(handleError);

    function handleResponse(data) {
        listElement.textContent = "";
        for (const el of data) {
            const liElement = document.createElement('li');
            liElement.textContent = `${el.commit.author.name}: ${el.commit.message}`;
            listElement.appendChild(liElement);
        }
    }

    function handleError(error) {
        listElement.textContent = "";
        const liElement = document.createElement('li');
        liElement.textContent = error.message;
        listElement.appendChild(liElement);
    }
}