function astroAdventure(input) {
  const n = parseInt(input[0]);
  const astronauts = {};

  // Parsing the astronaut details from the input
  for (let i = 1; i <= n; i++) {
    const [name, oxygenLevel, energyReserves] = input[i].split(' ');
    astronauts[name] = {
      oxygen: parseInt(oxygenLevel),
      energy: parseInt(energyReserves),
    };
  }

  // Processing the commands
  for (let i = n + 1; i < input.length; i++) {
    const command = input[i];
    if (command === 'End') {
      break;
    }

    const [action, astronautName, amount] = command.split(' - ');
    const astronaut = astronauts[astronautName];

    switch (action) {
      case 'Explore':
        if (astronaut.energy >= parseInt(amount)) {
          astronaut.energy -= parseInt(amount);
          console.log(`${astronautName} has successfully explored a new area and now has ${astronaut.energy} energy!`);
        } else {
          console.log(`${astronautName} does not have enough energy to explore!`);
        }
        break;

      case 'Refuel':
        const initialEnergy = astronaut.energy;
        astronaut.energy = Math.min(200, astronaut.energy + parseInt(amount));
        console.log(`${astronautName} refueled their energy by ${astronaut.energy - initialEnergy}!`);
        break;

      case 'Breathe':
        const initialOxygen = astronaut.oxygen;
        astronaut.oxygen = Math.min(100, astronaut.oxygen + parseInt(amount));
        console.log(`${astronautName} took a breath and recovered ${astronaut.oxygen - initialOxygen} oxygen!`);
        break;

      default:
        break;
    }
  }

  // Printing the final status of all astronauts
  for (const [name, { oxygen, energy }] of Object.entries(astronauts)) {
    console.log(`Astronaut: ${name}, Oxygen: ${oxygen}, Energy: ${energy}`);
  }
}