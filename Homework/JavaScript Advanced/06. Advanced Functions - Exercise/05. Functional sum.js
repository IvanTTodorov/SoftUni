function add(num) {
    const inner = function(a) {
        num += a; 
        return inner; 
    };
    inner.toString = function() {
        return num;
    }
    return inner; 

}
console.log(add(1).toString());
console.log(add(1)(6)(-3).toString());
