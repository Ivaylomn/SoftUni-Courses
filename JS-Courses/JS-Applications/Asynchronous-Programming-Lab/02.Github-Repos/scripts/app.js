function loadRepos() {
	const username = document.getElementById('username').value;
	const ulElements = document.querySelector('#repos');

	const url = `https://api.github.com/users/${username}/repos`;
	fetch(url)
		.then(response => {
			if (response.ok == false) {
				throw new Error(`${response.status} ${response.statusText}`);
			}
			return response.json();
		})
		.then(handleResponse)
		.catch(handleError);

	function handleResponse(data) {
		ulElements.innerHTML = '';
		for (const repo of data) {
			const liElement = document.createElement('li');
			liElement.innerHTML = `<a href="${repo.html_url}">
			${repo.full_name}
		</a>`;
			ulElements.appendChild(liElement);
		}
	}

	function handleError(error) {
		ulElements.innerHTML = '';
		ulElements.textContent = `${error.message}`;
	}
}