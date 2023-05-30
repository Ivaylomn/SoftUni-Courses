function editElement(element, match, replace) {
    let content = element.textContent
    let regex = new RegExp(match, 'g');
    let edited = content.replace(regex, replace);
    element.textContent = edited;
}