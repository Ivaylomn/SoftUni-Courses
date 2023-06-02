function onClick(text) {
    let textInput = text;
    let restorants = {};
    for (const el of textInput) {
       let [restorantName, workersAndSalary] = el.split(' - ');
       let inputWorkers = workersAndSalary.split(', ').map(w => {
          let [name, salary] = w.split(' ');
          salary = Number(salary);
          return { name, salary };
       });
       if (!restorants[restorantName]) {
          restorants[restorantName] = {
             workers: [],
             avaregeSalary() {
                return this.workers
                   .reduce((a, el) => a + el, 0) / this.workers.length;
             }
          }
       }
       restorants[restorantName].workers = restorants[restorantName].workers.concat(inputWorkers);
    }
    let sordetRestorant = Object.entries(restorants)
    .sort((a, b) => b[1].avaregeSalary() - a[1].avaregeSalary());
    let bestRestorant = sordetRestorant[0];
    console.log(restorants);

 }

onClick(["PizzaHut - Peter 500, George 300, Mark 800",
    "TheLake - Bob 1300, Joe 780, Jane 660"]
)