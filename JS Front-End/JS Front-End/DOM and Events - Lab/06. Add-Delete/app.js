function addItem() {
    const value = document.querySelector("#newItemText").value;
  
    const item = document.createElement("li");
    item.textContent = value;
  
    const deleteButton = document.createElement("a");
    deleteButton.href = "#";
    deleteButton.textContent = "[Delete]";
    deleteButton.addEventListener("click", (e) => {
      e.target.parentElement.remove();
    });
  
    item.appendChild(deleteButton);
  
    document.querySelector("ul").appendChild(item);
  }