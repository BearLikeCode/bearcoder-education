var buffer = Buffer.alloc(8);
console.log(buffer);

var buffer1 = Buffer.from([ 8, 6, 7, 5, 4, 0, 9]);
console.log(buffer1);
console.log(buffer1.isEncoding("utf8"));

var buffer2 = Buffer.from ([10, 12, 21]);
console.log(buffer2);

var buffer3 = Buffer.from("I'm a string", "utf-8");
console.log(buffer3);

var buffer4 = Buffer.alloc(16);
buffer4.write("Hello world!!!!");
console.log(buffer4);

console.log(buffer4.toString());
