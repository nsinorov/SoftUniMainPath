function makeAddressBook(array) {
    const addressBook = array.reduce((acc, curr) => {
      const [name, address] = curr.split(":");
      acc[name] = address;
      return acc;
    }, {});
    Object.entries(addressBook)
      .sort()
      .forEach(([name, address]) => {
        console.log(`${name} -> ${address}`);
      });
  }
  makeAddressBook([
    "Bob:Huxley Rd",
    "John:Milwaukee Crossing",
    "Peter:Fordem Ave",
    "Bob:Redwing Ave",
    "George:Mesta Crossing",
    "Ted:Gateway Way",
    "Bill:Gateway Way",
    "John:Grover Rd",
    "Peter:Huxley Rd",
    "Jeff:Gateway Way",
    "Jeff:Huxley Rd",
  ]);