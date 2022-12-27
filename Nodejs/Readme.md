# Nodejs Training
### What is Nodejs?
1. Nodejs is a platform for developing rich internet based Applications using Javascript.
2. Nodejs helps in executing JS files out of the browser. U can now execute the 
JS files from the Cmd prompt.
3. With this, U can achieve server side features using Javascript:
    - Perform File IO operations
    - Develop Server side Applications. 
    - Provide REST APIs.
    - Access OS level APIs.
    - Connect to databases. 
4. It is executing JS code from the Terminal. Unlike browser, U cannot have UI related 
    APIs: Accessing DOM Elements, UI related APIs will not be available. However, with Nodejs we can achieve the File Access, IO operations, Database operations and many more.
5. It is basically running JS files on Chrome's V8 JS Engine that is customized in Nodejs.
6. Ryan Dahl of Joyent Technologies developed Nodejs by taking out the Chrome's V8 Engine
and customizing it to execute JS files from the Cmd Prompt. It is now Open Source.
7. Nodejs uses a single threaded, async programming technology. With this, U can create Robust and faster Applications. 
    
### Installation of Nodejs
1. U can visit the https://nodejs.org/en/download/ website to download the version of the Nodejs suited to UR OS:<br>
Windows, Linux or MacOS. U can even have the Docker image for the same. 
2. U can install the software with all default settings. 
3. Nodejs interally sets the Environment variables to execute node commands from any where using UR terminal.  
### Creating Nodejs Files
1. All JS files can be executed with the Nodejs Environment. 
2. U create Files with extension .js and U R able to run them from the terminal. 
3. U can execute JS functions directly in the terminal using Node REPL
4. Read Evaluate Print Loop is a feature that allows User to give inputs directly to the terminal,which internally evaluates, prints the output and loops it for the next command to execute.
- There are basically 3 different functions with 2 variations:
    -   readFile 
    -   writeFile -> Creates a new file if it does not exist and writes to it, else simply writes to the file.
    -   appendFile -> Creates a new file if it does not exist and writes to it, else simply appends to the file.
    -   open =>All Operations can be done using one function
### Modules in Nodejs
- If a group of functions or classes has to be exposed to other JS files to be used by them, then U should export the functions in the form of Module. A module in Nodejs is a JS file that has an object called module.exports in it. 
- module.exports contain the group of methods that U wish to export. 
- The JS file that consumes this exports file will import it using require command. 
- The design of the Module in nodejs is based on CommonJs library that is available in JS. 
### How Nodejs works internally?
1. Nodejs is an Open souce Cross platform JS Runtime Environment which is popular among App developers who wish to develop apps with limited hardware configs.
2. Nodejs runs on Chrome's V8 Engine which is the core of the Google Chrome Browser. It actually like Running the JS file on Chrome without DOM.
3. It executes in a single process, single threaded Environment for every request made to the Application. It provides a set of Async IO APIs in its std libraries that prevent JS code from blocking. It is non Blocking, Single Threaded,  Async Programming Environment. 
### Standard Modules of Nodejs
- Nodejs comes with some built in modules that can be used to develop Applications. 
- The most common ones would be the file io, database interactions, server creations, os specific APIs, event handling, Console handling, readline and many more. 
- There is Nodejs Documentation that will give all info related to the APIs. 
#### fs Module
1. fs module helps in interacting with the File System of the machine that has Nodejs. 
2. It has APIs to read, write, remove, append files and directories.
3. It internally uses Streams to perform these operations. 
4. Stream is contigenous Uni directional memory where the data is pushed or recieved from a source called File
5. All std modules are the part of the nodejs installation, U dont refer them using the ./ Operator which implies the local directory.    
#### os Module 
1. Os module helps to get info about the current OS and its details. 
#### events Module 
#### http Module
### Express Module
### Developing a RESTFull Service with Express
### Testing the service with jQuery
