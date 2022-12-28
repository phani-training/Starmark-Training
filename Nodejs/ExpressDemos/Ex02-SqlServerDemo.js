const app = require("express")();
const parser = require('body-parser');
const server = require("mssql/msnodesqlv8");

/////////////////////Middleware/////////////////
app.use(parser.urlencoded({"extended" : true}));
app.use(parser.json())

//install the package called msnodesqlv8...
//import the msnodesqlv8
//create the connectionPool that represents the Connection to the database
/*
server: the name U give in SSMS to connect to the database
database: the allocated database name
driver : msnodesqlv8
options: an object with credential info: trustedConnection for Windows Authentication.  
TrustServerCertificate should be set to true to enable Security Certificate for UR Database
*/ 
const config = {
    server : '192.168.171.36',
    database : 'Phaniraj-CSMM40',
    driver : 'msnodesqlv8',
    options :{
        trustedConnection : true,
        TrustServerCertificate : true
    }
}
const pool = new server.ConnectionPool(config);

app.get("/Form", (req, res) => res.sendFile(__dirname + "/EmployeeAdding.html"));

app.get("/TableOfRecords", (req, res)=>res.sendFile(__dirname + "/Table.html"));

app.post("/formPost", (req, res)=>{
    const body = req.body;
    console.log(body);
    const query = `INSERT INTO EMPLOYEE VALUES(${body.id}, '${body.name}', '${body.address}',${body.salary})`;
    pool.connect().then(()=>{
        pool.request().query(query, (err, result) => {
            if (err)
                console.log(err)
            else
                res.send("Employee inserted successfully")
        })
    }).catch((err)=>{
        console.error(err)
    })
})

app.post("/", (req, res)=>{
    const body = req.body;
    const query = `INSERT INTO EMPLOYEE VALUES(${body.empId}, '${body.empName}', '${body.empAddress}',${body.empSalary})`;
    pool.connect().then(()=>{
        pool.request().query(query, (err, result) => {
            if (err)
                console.log(err)
            else
                res.send("Employee inserted successfully")
        })
    }).catch((err)=>{
        console.error(err)
    })
})
app.get('/', (req, res)=>{
    //connect to the database
    pool.connect().then(()=>{
        pool.request().query("SeleCT * FROM EMPLOYEE", (err, results)=>{
            if(err)
                console.error(err);
            else
                res.send(results.recordset);
        })
    }).catch((err)=>{
        if(err) console.log(err);
    })
})

app.get("/:id", (req, res)=>{
    console.log(req.params);
    const id = parseInt(req.params.id);
    pool.connect().then(()=>{
        pool.request().query(`select * from employee where empId = ${id}`, (err, result)=>{
            if(err) 
                console.error(err);
            else 
                res.send(result.recordset)
        })
    }).catch((err)=>{
        if(err) console.log(err);
    })
})

app.delete("/:id", (req, res)=>{
    const id = parseInt(req.params.id);
    pool.connect().then(()=>{
        pool.request().query(`delete from employee where empId = ${id}`, (err, result)=>{
            if(err) 
                console.error(err);
            else 
                res.send("record deleted successfully")
        })
    }).catch((err)=>{
        if(err) console.log(err);
    })
})


app.listen(1234, () => console.log("Server at 1234"))