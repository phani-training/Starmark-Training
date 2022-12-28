const express = require('express');
const parser = require('body-parser'); 
const app = express();

app.use(parser.urlencoded({extended : false}))

app.get('/', (req, res) => res.send("Welcome to Express training"))

app.get('/Home', (req, res) => res.sendFile(__dirname + "/Home.html"));
app.get('/Register', (req, res) => res.sendFile(__dirname + "/Register.html"));

app.get("/AfterRegister", (req, res)=>{
    const name = req.query.txtName;
    const email = req.query.txtEmail;
    res.send(`${name} is registered with Us and will be contacted later with the email Address shared with us as ${email}`)
})

app.post("/AfterRegister", (req, res)=>{
    if(req.body == null){
        res.send("The form does not contain body data in it");
    }else{
        const name = req.body.txtName;
        const email = req.body.txtEmail;
        res.send(`${name} is registered via HTTPPOST with Us and will be contacted later with the email Address shared with us as ${email}`)

    }
})

app.listen(1234, () => console.log("Server is available at 1234"));

/*
Create a new folder called ExpressDemo
install the express package in this folder
Open the terminal in the folder location and enter the command: npm install express
express will be installed in the node_modules with a reference of it mentioned in the package.json. 
package.json is the config settings for UR nodejs project. It contains info like dependencies, devDependencies, testing commands, execution commands and many more 
Create JS files in this directory.
U can execute the files like any other nodejs apps. 
*/ 