function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let tableElement = Array.from(document.querySelectorAll('tbody tr'));
      let searchedField = document.getElementById('searchField').value;
      if (searchedField === '') {
         return;
      }
      for (const el of tableElement) {
         let currentElement = el.textContent.toLowerCase();
         if (currentElement.includes(searchedField.toLowerCase())) {
            el.classList.add('select');
            //el.className = 'select';
         } else {
            el.classList.remove('select')
         }
      }
      document.getElementById('searchField').value = "";
   }
}