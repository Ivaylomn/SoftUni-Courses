function create(words) {
   const divElement = document.getElementById('content');
   divElement.addEventListener('click', clicked);
   for (const str of words) {
      const newDivElement = document.createElement('div');
      const paragraph = document.createElement('p');
      paragraph.textContent = str;
      paragraph.style.display = 'none';
      newDivElement.appendChild(paragraph);
      divElement.appendChild(newDivElement);
   }

   function clicked(e) {
      if (e.target.tagName == 'DIV' && e.target != 'content') {
         e.target.children[0].style.display = '';
      }
   }
}