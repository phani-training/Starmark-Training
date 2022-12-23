# CSS Programming
- CSS is a way of designing web content of HTML with formatting, coloring and other features like hiding, animating the content. 
- Earlier versions of HTML used Attributes to set the styles for the Elements which was very difficult to maintain. 
- Now all HTML Pages use CSS for defining the Stylings for the HTML Pages.
- They can be set at 3 different levels:
    - inline Styling: We can use the style attribute of the HTML elements to set the stype for the Tag. 
    - Interal Styling: We can use a Style tag within the HTML document that can be used to set styles for the HTML Document. It is applicable only to that document. 
    - External Styling: Create a Text based File with an Extension .css and define all the styles required in it. U can link the file in any of the HTML documents using link tag. This promotes more reusability. 
- CSS can be applied to the HTML elements in 3 different ways:
    - For the Tag: U can set the style for all the elements of the matching tag. 
    - For the ID: U can set the style for the specific element using (#). 
    - For the Class: U can group a set of elements (Not nessasarily of the same type) as a class and define the CSS for it using (.)  ...
- CSS has styles and API support to apply formatting, font definitions, coloring, spacing, animating, show-hide, resizing and many more. 
- For professional CSS Designing, U can use Frameworks like Bootstrap that contains a host of classes that could be set on UR HTML Pages. Bootstrap is opensource and is available as free library. 
- U set the CSS at various levels depending on the specific requirements of the Element. For common look and feel, we would implement an External CSS, for specific Pages we implement internal Styling and for special tags, it will be inline styling. The inline styling will superceed the other stylings defined externally or internally. 

### Positions
1. Define the location where the elements will be placed in the HTML document.
2. Has 5 Positions:
    - static: They dont affect the placing of the elements, this is the default position. It is positioned according to the flow of the document elements. 
    - relative: They are placed with respect to their parent element. 
    - fixed: Placed on the Document and will not be movable. They are stationed at the same position irrespective of the document position. 
    - absolute: Positioned relative to the nearest positioned ancestor. They are removed from the normal flow and can overlap on other elements.
    -sticky: Placed on the document based on the User's scrolling position.  Scrolling back to the View port will remove the stickyness and will behave like relative element.
     
### Responsive Web Design
- RWD is design trend that is followed currently in all web applications where the content will be realigned based on the Device in which it is viewed. There are 2 popular Web Designs: Flex Design and Grid Design. 
- With Flex model, U will first create a Container with display property set to flex. Elements will be placed in the flex based on the direction that U to place the elements. 
- With Grid Model, we can divide our web Viewport into 12 columns and place the Elements accordingly. Some critics would not recommend Grid Model as they are not so user responsive as compared to flex model. 


