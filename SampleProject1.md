# HTML and Javasript Hackathon

Create an HTML Application with JS as scripting language that will work as a string Encoder Software: <br/>
Here is the Text that contains all the 26 alphabets in English:
```
"the quick brown fox jumps over the lazy dog"
```
We can generate a Code for any letter in the following manner: 
The code is a combination of 2 Digits. The First digit represens the index of the word(first occurrence), which contains the letter and the second digit represents the index of that letter in the found word.
For eg: the letter "m" is found in the word "jumps" which is in the index 4 in the sentence and in that word, "m" is found at index 2. So the code would be 42. 
Likewise the letter "v" is found in the word "over" which is in the index 6 of the sentence and in that word, "v" is at index 1. Hense the code for v will be 61.
Develop a Web App that allows Users to type a word and on click of a button, it should display the encoded string in a &lt;p&gt; Tag.

Points to remember: 
inputs are case-insensitive that can contain one or more words with delimited by space.  <br/>
output should be a string that contains the codes for each letter seperated by comma. The space in the input should be replaced by a hypen(-) in the output.

Sample inputs and outputs:  <br/>
bangalore: 20,71,24,82,71,70,22,21,02  <br/>
west campus: 23,02,44,00-13,71,42,43,11,44 <br/>
