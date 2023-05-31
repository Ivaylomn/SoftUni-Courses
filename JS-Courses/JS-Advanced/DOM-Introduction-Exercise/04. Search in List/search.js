function search() {
   let townsELements = Array.from(document.getElementById('towns').children);
   let searchText = document.getElementById('searchText').value;
   let matches = 0;
   for (const el of townsELements) {
      if (el.textContent.includes(searchText)) {
         el.style.fontWeight = 'bolder';
         el.style.textDecoration = 'underline';
         matches++
      } else {
         el.style.fontWeight = 'normal';
         el.style.textDecoration = 'none';
      }
   }
   document.getElementById('result').textContent = `${matches} matches found`;
}
