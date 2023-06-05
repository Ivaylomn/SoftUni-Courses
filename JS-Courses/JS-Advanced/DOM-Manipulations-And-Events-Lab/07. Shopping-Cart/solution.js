function solve() {
   document.getElementsByClassName('shopping-cart')[0].addEventListener('click', onClick);
   document.getElementsByClassName('checkout')[0].addEventListener('click', checkout);
  
   const cart = [];
   const output = document.getElementsByTagName('textarea')[0];
   output.value = '';

   function onClick(e) {
      if (e.target.tagName == 'BUTTON' && e.target.classList.contains('add-product')) {
         const product = e.target.parentNode.parentNode;
         const name = product.querySelector('.product-title').textContnent;
         const price = Number(product.querySelector('.product-line-price').textContnent);
         cart.push({
            name,
            price
         })
         output.value += `Added ${name} for ${price.toFixed(2)} to the cart.\n`;
      }
   }

   function checkout() {
      const product = new Set();
      cart.forEach(x => product.add(x));
      const total = cart.reduce((a, c) => a + c.price, 0);
      output.value += `You bought ${[...product.keys()].join(', ')} for ${total.toFixed(2)}.`;
   }
}