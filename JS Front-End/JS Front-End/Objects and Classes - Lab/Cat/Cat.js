class Cat {
    constructor(name, age) {
      this.name = name;
      this.age = age;
    }
    meow() {
      console.log(`${this.name}, age ${this.age} says Meow`);
    }
  }
  
  function createCat(array) {

    let cats = [];
  
    for (let index = 0; index < array.length; index++) {
      let [name, age] = array[index].split(" ");
      cats.push(new Cat(name, age));
    }
  
    for (const cat of cats) {
      cat.meow();
    }
  }
  createCat(["Mellow 2", "Tom 5"]);