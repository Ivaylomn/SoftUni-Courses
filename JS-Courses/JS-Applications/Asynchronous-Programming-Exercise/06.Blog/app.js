function attachEvents() {
    document.getElementById('btnLoadPosts').addEventListener('click', getAllPost);
    document.getElementById('btnViewPost').addEventListener('click', renderPostAndComments);
}

attachEvents();

async function renderPostAndComments() {
    const selectId = document.getElementById('posts').value;

    const [post, comments] = await Promise.all([
        getPostByPostId(selectId),
        getCommentsByPostId(selectId)
    ])

    document.getElementById('post-title').textContent = post.title;
    document.getElementById('post-body').textContent = post.body;

    const ulElement = document.getElementById('post-comments');
    ulElement.replaceChildren();
    comments.forEach(x => {
        const liELement = document.createElement('li');
        liELement.textContent = x.text;
        liELement.id = x.id;

        ulElement.appendChild(liELement);
    })
}

async function getAllPost() {
    const url = `http://localhost:3030/jsonstore/blog/posts`;

    const res = await fetch(url);
    const data = await res.json();

    const selectELement = document.getElementById('posts');
    selectELement.replaceChildren();
    Object.values(data).forEach(x => {
        const optionElement = document.createElement('option');
        optionElement.textContent = x.title;
        optionElement.value = x.id;

        selectELement.appendChild(optionElement);
    })
}

async function getPostByPostId(postId) {
    const url = `http://localhost:3030/jsonstore/blog/posts/${postId}`;

    const res = await fetch(url);
    const data = await res.json();

    return data;
}

async function getCommentsByPostId(postId) {
    const url = 'http://localhost:3030/jsonstore/blog/comments';

    const res = await fetch(url);
    const data = await res.json();
    const comments = Object.values(data).filter(x => x.postId == postId);
    return comments;
}