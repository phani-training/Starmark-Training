const os = require("os");
console.log(os.version());
console.log(os.hostname())
console.log(os.arch());
const cpusInfo = os.cpus();
for(const info of cpusInfo){
    console.log(JSON.stringify(info))
}
console.log(os.totalmem());//Display the memory in GB...
console.log(os.freemem());
console.log(os.userInfo())
//console.log("The total no of CPUs in this machine is " + os.cpus().length)