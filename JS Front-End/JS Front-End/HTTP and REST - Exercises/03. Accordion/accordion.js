function toggle() {
    const content = document.querySelector("#extra");
    const button = document.querySelector("span.button");
  
    content.style.display = content.style.display === "block" ? "none" : "block";
    button.textContent = button.textContent === "More" ? "Less" : "More";
  }