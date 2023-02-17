# Jasmine Framework
1. Create a new Folder for the Project and Open it from the Cmd Prompt
2. Run the below Commands from the Cmd
```
npm init -y
npm install --save-dev jasmine
npx jasmine init
```
3. Open the jasmine.json file to set UR Spec file locations. 

4. Open the package.json of UR Project and make the following changes in the scripts section of the file:
```
"scripts": {
    "test": "jasmine"
  }
```

5. Write UR Testcases in the Spec folder with a suffix called spec.js. 
6. Run the Tests by executing a command:
```
npm test
``` 


