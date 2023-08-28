function createHeroCatalog(input) {
    let heroes = [];
    input.forEach((element) => {
      let [name, level, ...items] = element.split(" / ");
      heroes.push({
        name,
        level,
        items,
      });
    });
    heroes
      .sort((a, b) => a.level - b.level)
      .forEach((hero) => {
        console.log(`Hero: ${hero.name}`);
        console.log(`level => ${hero.level}`);
        console.log(`items => ${hero.items}`);
      });
  }