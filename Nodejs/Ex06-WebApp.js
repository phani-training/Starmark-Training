//WebApp.js will handle web requests for the pages we create. 
const http = require('http');
const fs = require('fs');
const httpParse = require('url').parse; 
const dir = __dirname; //const for the current directory of the Application. 

function displayPage(res, url){
    const file = dir + url + ".html";
    fs.createReadStream(file).pipe(res);//It will read the stream data of the file and push the stream to the Response and end the response
}
function errorPage(res){
    res.writeHead(200, {'Content-type' :'text/html'});
    res.write("<h1 style='color:red'>OOPS! Something wrong happened</h1>")
    res.write("<hr>")
    res.write("<h2>The Page U have requested is not available with Us!!!")
}

http.createServer((req, res)=>{
    if(req.method == "GET"){
        const query = httpParse(req.url).query;
        if(query !=null){
            let obj = httpParse(req.url, true).query;
            const msg = `Thanks Mr.${obj.txtName} for registering with Us! UR EMail ${obj.txtEmail} is registered and will be contacted`;
            res.write(msg);
            res.end();
            return
        }
    }else if(req.method == "POST"){
        req.on("data", function(inputs){//data is an event triggered when the page is posted
            res.write(inputs);
            res.end();
            return;
        })
    }
    switch (req.url) {
        case "/favicon.ico":
            res.end();
            return;
        case "/Register":
            displayPage(res, req.url);
            break;
        case "/Home":
            displayPage(res, req.url);
            break;
        default:
            errorPage(res);
            res.end();
            break;
    }
}).listen(1234);