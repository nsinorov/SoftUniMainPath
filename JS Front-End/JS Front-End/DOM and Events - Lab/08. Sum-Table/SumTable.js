function sumTable() {
    const prices = Array.from(
      document.querySelectorAll("td:nth-child(2):not(#sum)")
    );
    const total = prices.reduce((acc, curr) => {
      return acc + Number(curr.textContent);
    }, 0);
    document.querySelector("#sum").textContent = total;
  }