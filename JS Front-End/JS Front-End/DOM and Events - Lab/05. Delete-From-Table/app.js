function deleteByEmail() {
    const email = document.querySelector('input[name="email"]').value;
    const emailBoxes = Array.from(
      document.querySelectorAll("td:nth-child(even)")
    );
  
    const userEmailBox = emailBoxes.find((box) => box.textContent == email);
    const result = document.querySelector("#result");
    if (userEmailBox) {
      userEmailBox.parentElement.remove();
      result.textContent = "Deleted.";
      return;
    }
    result.textContent = "Not found.";
  }