const http = require("http");
//Http is std protocol for transfering text among the internet applications.
//http module is a nodejs module used to create Web Apps with server details in it. It exposes using a certain port no and handle requests and provides responses to the User requests made using HTTP. 

console.log("Server is available at port: 1234");
http.createServer(function(req, res, err){
    if(err)
        console.log(err);
    console.log(req.url);
    if(req.url == "/Employees")
        res.write("Employees Page of the Application");
    else if (req.url == "/Customers")
        res.write("Customer Page of the App")
    else
        res.write("Default page of the Application");
    res.end();

}).listen(1234)
