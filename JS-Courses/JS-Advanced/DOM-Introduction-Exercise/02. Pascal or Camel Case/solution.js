function solve() {
  let input = document.getElementById('text').value.toLowerCase().split(' ');
  let namingConvetion = document.getElementById('naming-convention').value;
  if (namingConvetion === 'Camel Case') {
    for (let i = 1; i < input.length; i++) {
      input[i] = input[i][0].toUpperCase() + input[i].slice(1);
    }
  } else if (namingConvetion === 'Pascal Case') {
    for (let i = 0; i < input.length; i++) {
      input[i] = input[i][0].toUpperCase() + input[i].slice(1);
    }
  } else {
    document.getElementById('result').textContent = 'Error!';
    return;
  }
  document.getElementById('result').textContent = input.join('');
}