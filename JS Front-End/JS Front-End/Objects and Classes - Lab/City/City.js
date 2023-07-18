function city(param){

    const entries = Object.entries(param);
    
    for (const [key, value] of entries) {
      console.log(`${key} -> ${value}`);
    }
    
    }
    
city()