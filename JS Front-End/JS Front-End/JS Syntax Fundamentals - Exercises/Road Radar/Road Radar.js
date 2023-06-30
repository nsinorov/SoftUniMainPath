function solve(speed, area) {
    let speedLimit = 0;
    if (area === "motorway") {
      speedLimit = 130;
    } else if (area === "interstate") {
      speedLimit = 90;
    } else if (area === "city") {
      speedLimit = 50;
    } else if (area === "residential") {
      speedLimit = 20;
    }
    if (speed <= speedLimit) {
      console.log(`Driving ${speed} km/h in a ${speedLimit} zone`);
    } else {
      let status = "";
      let diff = Math.abs(speed - speedLimit);
      if (diff <= 20) {
        status = "speeding";
      } else if (diff > 20 && diff <= 40) {
        status = "excessive speeding";
      } else {
        status = "reckless driving";
      }
      console.log(
        `The speed is ${diff} km/h faster than the allowed speed of ${speedLimit} - ${status}`
      );
    }
  }
  solve(120, "interstate");