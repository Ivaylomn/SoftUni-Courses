function listProcessor(arr) {
    let output = [];
    let obj = {
        add,
        remove,
        print
    }
    for (const el of arr) {
        const [command, text] = el.split(' ');
        if (command == 'add') {
            obj.add(text);
        } else if (command == 'remove') {
            obj.remove(text);
        } else {
            obj.print(text);
        }
    }
    
    function add(element) {

        output.push(element);

    }

    function remove(element) {

        output = output.filter(e => e !== element);

    }

    function print() {

        console.log(output.join(','));

    }
}

listProcessor(['add hello', 'add again', 'remove hello', 'add again', 'print']);
listProcessor(['add pesho', 'add george', 'add peter', 'remove peter', 'print']);