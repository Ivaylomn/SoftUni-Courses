function wordsUpperCas(text) {
    let splited = text.replace(/[^\w\s]/g, '').toUpperCase();
    console.log(splited.split(' ').join(', '));
}
wordsUpperCas('Functions in JS can be nested, i.e. hold other functions');
wordsUpperCas('hello');