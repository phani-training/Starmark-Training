# jQuery Training
## jQuery Basics:
### What is jQuery?
1. jQuery is an Open source library that contains APIs for manupulating DOM elements of an HTML Document. 
2. It has APIs to search for the elements of the Document and perform actions or handle events of those elements. 
3. Its moto is "WRITE LESS AND GET MORE". With this library, U can do lot of work with minimal code like handling events, Animations, CSS modifications and making Ajax Calls to Server side RESTFull APIs.
4. It is JS only. Here we use JS to call the APIs of jQuery and get the required results.
5. It is distributed as a single JS file. It can be downloaded from the internet as a minified file with very small file size. U should include the File in UR HTML Document like any other JS file that U would consume.
6. There is a CDN(Content Delivery Network) server from which U can refer the jQuery File in ur document. CDNs are cloud based servers maintained by trustfull Organizations like Google, MS, Yahoo and many more where the File will be stored and maintained.  This is usually done on Production level Apps where the App developer need not maintain the jQuery file.

### How to download jQuery?
1. jQuery is maintained by https://jquery.com/download/ and U should download the minified version of the file which is suffixed with the versionno.min.js.
2. U can also refer the CDN location of the jQuery. In this case, the Consumer App must be connected to internet all the time. U can google to find the CDN server of the prominent Organizations.

### How to use jQuery?
1. Once the file is refered in the document,we could use the APIs of jQuery to perform various tasks.
2. Scripts are written in JS in the HTML Document. 

### document.ready
- The jQuery Library is accessible using the jQuery object. Its short form is $. 
- The $ is a function, it takes an argument of a selector.A selector is an HTML element or a document, a CSS class or a ID of the element. document is the default selector. It refers to the document object of the HTML Page. 
- ready fn of the $ will be triggered as an Event handler to the load event of the window object. It means that when the DOM structure is ready to be loaded into the browser, this event will be triggered. The handler of the event is implemented using the ready function.
- Every jquery function returns the jQuery object thru which U could invoke events associated with the selected Element. This is called as Chaining of Events in jQuery.  

### Selectors
1. To select an element by id we prefix the id with #. 
2. To select an Element by Tag we use directly the name of the tag within "". U might get multiple tag references which U could access individual element by eq().
3. To select elements on a Class name we use the (.) operator preceding the class name.
4. To select elements with attribute we use element:attribute  in [] => $("[input[type:checked]")

### DOM Traversing:
1. To find element no 3 in the DOM: -> $("div:eq(2)")
2. To get a 2nd child element of the type p from the parent div: ->$("div").children("p:eq(1)")
3. To get the parent from the existing element: -> $(this).parent()
4. To fing a parent in an hirarchy from the existing element: -> $(this).parents("ul")
5. To access elements at the same level: $(this).siblings("selector")

#### Effects
1. .hide() =>Hide the matched elements.
2. .show() =>Display the matched elements.
3. .toggle()=>Display or hide the matched elements.
4. fadeIn() => Display the matched elements by fading them to opaque.
5. fadeOut() => Hide the matched elements by fading them to transparent.
6. fadeTo() => Adjust the opacity of the matched elements.
7. slideDown() => Display the matched elements with a sliding motion.
8. slideUp() => Hide the matched elements with a sliding motion.
9. slideToggle() => Display or hide the matched elements with a sliding motion.
10. animate() => For Custom Animations like moving the element.

### Ajax Features:
- Ajax stands for Asynchronous Javascript and XML.
- Uses XmlHttpRequest(XHR) to make requests to the server. 
- Helpful for creating Single Page Apps. 
- JS uses XHR for accessing server side APIs.
- For Our Server,we are using json-server, a NODEJS based server App. 
    - Read the json-server NPM documentation on how to set the server.
- jQuery has 3 functions to perform Ajax Operations
    - $.get => For Get Operations
    - $.post => For POST or Adding operations.
    - $.ajax => For PUT and DELETE Operations.
- All the Functions are async functions.

### DOM Manipulations
- DOM elements can be accessed using selectors.
- append method is used to insert content within the selected element.
- html() is used to get the HTML contents of the first element.
- text method is used to get/set the text of the element. 
- children method gets the immediate children of the element
- find method gets the matching element under it at any level.
- parent method gets the immediate parent
- parents methods gets all the parent elements matching the selection condition.
- remove method is used to remove the selected element or list of elements. 

### Complete Example