for (let year = 2014; year <= 2050; year++) {
    const janFirst = new Date(year, 0, 1); // January is month 0
    if (janFirst.getDay() === 0) {
        console.log(`January 1st, ${year} is a Sunday.`);
       
    } 
}
