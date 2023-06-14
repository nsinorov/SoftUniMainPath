Create a Web page, holding like the following:

![image](https://github.com/nsinorov/SoftUniMainPath/assets/45227327/66ec4054-e205-49e6-864e-31db7fd74bfb)

Use the texts from the file site-texts.txt.
Create two files: simple-site-layout.html and styles.css.
Change the document title to "Simple Site Layout"

### Requirements:

    <body> that contains: header, aside, main, footer all with:
  
    o border-radius: 3px;
    o background: rgb(181, 216, 255);
    o padding: 5px 10px;
    
The elements into the body:

    • <header> with
      o <h1> text that is displayed as inline block and is vertically aligned in the middle;
      
    • <aside> tag that contains:
      o <ul> tag for unordered list
      
    ▪ list-style-type: none;
    ▪ margin: 0px;
    ▪ padding: 5px;
    ▪ <li> tag for list item
    
    ▪ <a> tag for hyperlink
      o display: block;
      o padding: 5px 0px;
      o color: rgb(86, 40, 129);
      o text-decoration: none;

    ▪ <main> tag that contain:
      o <h1> text title for the tasks
      o <ul> tag with:
      
    ▪ <li> for the tasks with their status
    
    • <footer> tag that contain:
      o <div> with copyright sign and tex
      
### CSS Grid:

In the styles.css:

    • Make the body grid container by displaying the grid.
    • Define two grid columns and their size. 100px for the first column and auto for the second. 
    • Define the grid areas: header, main, aside, footer.
    • Reference the grid areas: "header header", "aside main", "footer footer".
    • Set gap: 10px.

### Example: 

![image](https://github.com/nsinorov/SoftUniMainPath/assets/45227327/eb096214-8da4-4f6d-bf03-5565452c561f)
