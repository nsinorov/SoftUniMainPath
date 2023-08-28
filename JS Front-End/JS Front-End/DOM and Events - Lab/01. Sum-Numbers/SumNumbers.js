function calc() {
  const firstInput = document.getElementById("num1");
  const secondInput = document.getElementById("num2");
  const sum = Number(firstInput.value) + Number(secondInput.value);
  document.getElementById("sum").value = sum;
}