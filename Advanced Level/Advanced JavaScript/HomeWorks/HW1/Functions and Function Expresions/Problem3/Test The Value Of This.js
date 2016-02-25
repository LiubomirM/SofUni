var obj = {
    text: 'Some text'
};

function testContext() {
    console.log(this);
}

function outer() {
    function inner() {
        console.log(this);
    }
    return inner();
}

console.log('Global context:');
testContext();

console.log('From within another function:');
outer();

console.log('As an object');
testContext.call(obj);