const apiUrl = 'http://localhost:3030/jsonstore/tasks/';
let currentEditId = null;

// DOM elements
const locationInput = document.getElementById('location');
const temperatureInput = document.getElementById('temperature');
const dateInput = document.getElementById('date');
const addButton = document.getElementById('add-weather');
const editButton = document.getElementById('edit-weather');
const listDiv = document.getElementById('list');
const loadHistoryButton = document.getElementById('load-history');

// Load the weather history
loadHistoryButton.addEventListener('click', loadHistory);

// Add a new weather record
addButton.addEventListener('click', addWeather);

// Edit a weather record
editButton.addEventListener('click', editWeather);

async function loadHistory() {
    listDiv.innerHTML = '';
    const response = await fetch(apiUrl);
    const data = await response.json();
    
    Array.from(Object.values(data)).forEach(record => {
        listDiv.appendChild(createRecordElement(record));
    });
}

function createRecordElement(record) {
    const container = document.createElement('div');
    container.className = 'container';
    container.innerHTML = `
        <h2>${record.location}</h2>
        <h3>${record.date}</h3>
        <h3 id="celsius">${record.temperature}</h3>
        <div id="buttons-container">
            <button class="change-btn">Change</button>
            <button class="delete-btn">Delete</button>
        </div>`;
    
    container.querySelector('.change-btn').addEventListener('click', () => loadEditForm(record));
    container.querySelector('.delete-btn').addEventListener('click', () => deleteWeather(record._id, container));
    
    return container;
}

function loadEditForm(record) {
    currentEditId = record._id;
    locationInput.value = record.location;
    temperatureInput.value = record.temperature;
    dateInput.value = record.date;
    
    addButton.disabled = true;
    editButton.disabled = false;
}

async function addWeather() {
    const newRecord = {
        location: locationInput.value,
        temperature: temperatureInput.value,
        date: dateInput.value
    };

    const response = await fetch(apiUrl, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(newRecord)
    });

    if (response.ok) {
        locationInput.value = '';
        temperatureInput.value = '';
        dateInput.value = '';
        loadHistory();
    }
}

async function editWeather() {
    const updatedRecord = {
        location: locationInput.value,
        temperature: temperatureInput.value,
        date: dateInput.value
    };

    const response = await fetch(apiUrl + currentEditId, {
        method: 'PUT',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(updatedRecord)
    });

    if (response.ok) {
        locationInput.value = '';
        temperatureInput.value = '';
        dateInput.value = '';
        addButton.disabled = false;
        editButton.disabled = true;
        currentEditId = null;
        loadHistory();
    }
}

async function deleteWeather(id, element) {
    const response = await fetch(apiUrl + id, {
        method: 'DELETE'
    });

    if (response.ok) {
        element.remove();
    }
}

// Initial load of the weather history
loadHistory();
