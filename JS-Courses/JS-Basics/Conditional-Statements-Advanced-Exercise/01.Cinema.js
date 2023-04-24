function cinema(input) {
    let TypeOfProjection = input[0];
    let r = Number(input[1]);
    let c = Number(input[2]);

    let price = 0.0;
    if (TypeOfProjection === "Premiere") {
        price = 12.00;
    } else if (TypeOfProjection === "Normal") {
        price = 7.50;
    } else if (TypeOfProjection === "Discount") {
        price = 5.00;
    }

    let totalPrice = r * c * price;
    console.log(`${totalPrice.toFixed(2)} leva`);
}

cinema(["Premiere",
"10",
"12"]);
cinema(["Normal",
"21",
"13"]);
cinema(["Discount",
"12",
"30"])

