function solve() {
  let text = document
    .getElementById('input').value
    .split('.')
    .filter(x => x);
  let result = '<p>';
  if (text.length <= 3) {
    for (let i = 0; i < text.length; i++) {
      result += `${text[i]}.`;
    }
    result += '</p>';
  } else {
    while (text.length > 0) {
      for (let i = 0; i < 3; i++) {
        result += `${text[i]}.`;
        text.shift();
      }
      result += '</p>';
      document.getElementById('output').innerHTML = result;
    }
    return;
  }
  document.getElementById('output').innerHTML = result;
}