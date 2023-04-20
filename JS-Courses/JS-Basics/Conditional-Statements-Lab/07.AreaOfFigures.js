function areaOfFigures(input) {
    let result;
    let figureType = input[0];
    if (figureType === "square") {
        let lenght = Number(input[1]);
        result = lenght * lenght;
    } else if (figureType === "rectangle"){
        let lenghtOne = Number(input[1]);
        let lenghtTwo = Number(input[2]);
        result = lenghtOne * lenghtTwo
    } else if (figureType === "circle"){
        let radius = Number(input[1]);
        result = (Math.PI * radius * radius).toFixed(3);
    } else {
        let lenght  = Number(input[1]);
        let height  = Number(input[2]);
        result = ((lenght * height) / 2).toFixed(3);
    }
    console.log(result);
}

areaOfFigures(["square", "5"]);
areaOfFigures(["rectangle", "7", "2.5"]);
areaOfFigures(["circle", "6"]);
areaOfFigures(["triangle", "4.5", "20"]);
