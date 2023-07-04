window.addEventListener('DOMContentLoaded', start);
//window.onload = start;

async function start() {
    const mainElement = document.querySelector('main')
    const recipe = await getRecipes();
    mainElement.replaceChildren();

    recipe.map(createPreview).forEach(x => mainElement.appendChild(x));
}

function createPreview(recipe) {
    const articleElement = document.createElement('article');
    articleElement.classList.add('preview');

    const divElement = document.createElement('div');
    divElement.classList.add('title');
    articleElement.appendChild(divElement);

    const hTwoElement = document.createElement('h2');
    hTwoElement.textContent = recipe.name;
    divElement.appendChild(hTwoElement);

    const divTwoElement = document.createElement('div');
    divTwoElement.classList.add('small');
    articleElement.appendChild(divTwoElement);

    const imgElement = document.createElement('img');
    imgElement.src = recipe.img;
    divTwoElement.appendChild(imgElement);

    articleElement.addEventListener('click', () => recipeDetailsOnClick(recipe._id, articleElement));

    return articleElement;
}

async function recipeDetailsOnClick(id, element) {
    const recipeDetails = await getRecipDetailsById(id);

    const articleElement = document.createElement('article');
    const hTwoElement = document.createElement('h2');
    hTwoElement.textContent = recipeDetails.name;

    const divElementWithClassBand = document.createElement('div');
    divElementWithClassBand.classList.add('band');
    const imgDivElement = document.createElement('div');
    imgDivElement.classList.add('thumb');

    const imgElement = document.createElement('img');
    imgElement.src = recipeDetails.img;

    imgDivElement.appendChild(imgElement);

    const ingredientsDivELement = document.createElement('div');
    ingredientsDivELement.classList.add('ingredients');

    const hThreeElement = document.createElement('h3');
    hThreeElement.textContent = 'Ingredients:';

    const underListWithIngrediantELement = document.createElement('ul');
    recipeDetails.ingredients.forEach(x => {
        const liElement = document.createElement('li');
        liElement.textContent = x;

        underListWithIngrediantELement.appendChild(liElement);
    })

    ingredientsDivELement.appendChild(hThreeElement);
    ingredientsDivELement.appendChild(underListWithIngrediantELement);

    divElementWithClassBand.appendChild(imgDivElement);
    divElementWithClassBand.appendChild(ingredientsDivELement);

    const divElementWithClassDescription = document.createElement('div');
    divElementWithClassDescription.classList.add('description');

    const htreePreparationElement = document.createElement('h3');
    htreePreparationElement.textContent = 'Preparation:';
    divElementWithClassDescription.appendChild(htreePreparationElement);

    recipeDetails.steps.forEach(x => {
        const paragraph = document.createElement('p');
        paragraph.textContent = x;

        divElementWithClassDescription.appendChild(paragraph);
    })

    articleElement.appendChild(divElementWithClassBand);
    articleElement.appendChild(divElementWithClassDescription);

    element.replaceWith(articleElement)
}

async function getRecipes() {
    const url = 'http://localhost:3030/jsonstore/cookbook/recipes';
    const res = await fetch(url);
    const data = await res.json();

    return Object.values(data);
}

async function getRecipDetailsById(id) {
    const url = 'http://localhost:3030/jsonstore/cookbook/details/' + id;
    const res = await fetch(url);
    const data = await res.json();
    
    return data;
}