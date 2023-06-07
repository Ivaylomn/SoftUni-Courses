function solve(area, vol, input) {
    // let result = [];
    // let parsed = JSON.parse(input);
    // for (const el of parsed) {
    //     result.push({
    //         area: area.call(el),
    //         volume: vol.call(el)
    //     })
    // }
    //return result;
    
    return JSON.parse(input).map(x => ({
        area: area.call(x),
        volume: vol.call(x)
    }));
}
const input = `[
{"x":"1","y":"2","z":"10"},
{"x":"7","y":"7","z":"10"},
{"x":"5","y":"2","z":"10"}
]`;
const inputTwo = `[
    {"x":"10","y":"-22","z":"10"},
    {"x":"47","y":"7","z":"-5"},
    {"x":"55","y":"8","z":"0"},
    {"x":"100","y":"100","z":"100"},
    {"x":"55","y":"80","z":"250"}
    ]`;

console.log(solve(area, vol, input));
console.log(solve(area, vol, inputTwo));

function area() {
    return Math.abs(this.x * this.y);
};

vol()
function vol() {
    return Math.abs(this.x * this.y * this.z);
};
