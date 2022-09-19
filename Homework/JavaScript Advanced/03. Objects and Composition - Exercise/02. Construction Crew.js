     function solve(input) {
     
    if(input.dizziness == true) {
        input.levelOfHydrated +=  0.1 * input.experience * input.weight;
        input.dizziness = false; 
    }
   console.log(input);
  }

solve({ weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true });
    solve({ weight: 80,
        experience: 1,
        levelOfHydrated: 0,
        dizziness: false });