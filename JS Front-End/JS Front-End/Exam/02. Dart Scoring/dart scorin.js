function solve() {
    let playerInput = document.getElementById('player');
    let scoreInput = document.getElementById('score');
    let roundInput = document.getElementById('round');
    let addButton = document.getElementById('add-btn');
    let sureList = document.getElementById('sure-list');
    let scoreboardList = document.getElementById('scoreboard-list');
    let clearButton = document.querySelector('.clear');
  
    if (!playerInput || !scoreInput || !roundInput || !addButton || !sureList || !scoreboardList || !clearButton) {
      console.error("One or more elements are not found in the DOM");
      return;
    }
  
    addButton.addEventListener('click', function () {
      let playerName = playerInput.value.trim();
      let score = scoreInput.value.trim();
      let round = roundInput.value.trim();
  
      if (playerName && score && round) {
        let li = document.createElement('li');
        li.innerHTML = `
          <strong>${playerName}</strong>: ${score} (Round ${round})
          <button class="edit">Edit</button>
          <button class="ok">Ok</button>
        `;
  
        sureList.appendChild(li);
        playerInput.value = '';
        scoreInput.value = '';
        roundInput.value = '';
        addButton.disabled = true;
      }
    });
  
    sureList.addEventListener('click', function (event) {
      let li = event.target.parentElement;
      
      if (!li) {
        console.error("Parent element of the clicked target is not found");
        return; 
      }
  
      if (event.target.classList.contains('edit')) {
        let playerNameElem = li.querySelector('strong');
  
        if (!playerNameElem) {
          console.error("Player name element is not found in the clicked list item");
          return;
        }
  
        let score = li.textContent.split(':')[1].split('(Round')[0].trim();
        let round = li.textContent.split('Round ')[1].split(')')[0];
        playerInput.value = playerNameElem.textContent;
        scoreInput.value = score;
        roundInput.value = round;
        li.remove();
        addButton.disabled = false;
  
      } else if (event.target.classList.contains('ok')) {
        let editButton = li.querySelector('.edit');
        let okButton = li.querySelector('.ok');
        if (editButton) editButton.remove();
        if (okButton) okButton.remove();
  
        scoreboardList.appendChild(li);
        addButton.disabled = false;
      }
    });
  
    clearButton.addEventListener('click', function () {
      location.reload(); // Reload the application
    });
  }
  