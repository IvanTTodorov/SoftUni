function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick); 
 
 

   function onClick () {
      let input = JSON.parse(document.querySelector('#inputs textarea').value); 
      let bestSalary = 0;
      let bestName = '';
      let output = {}; 

      for (let i = 0; i < input.length; i++) {  
         let arrCurrentRestaurant = input[i].split(' - ');
         let restaurantName = arrCurrentRestaurant.shift(); 
         let staff = arrCurrentRestaurant[0].split(', '); 
          
         for (const worker of staff) {  
            let [name,salary] = worker.split(' '); 
            if(!output.hasOwnProperty(restaurantName)) { 
               output[restaurantName] = {};
            } 
            if(output.hasOwnProperty(restaurantName)) {  
               output[restaurantName][name] = Number(salary);
            }
         } 
      } 
       
      let entries = Object.entries(output); 
      for (let entry of entries) { 
         let totalSalary = 0;  
         let avgSalary = 0; 
         let key = entry[0];
         let values = Object.values(entry[1]); 
          
         for (const salary of values) {
            totalSalary += salary;
         } 
         avgSalary = totalSalary / values.length;
         if(bestSalary < avgSalary) { 
            bestSalary = avgSalary; 
            bestName = key;
         }
      }  
       
      let result = Object.entries(output[bestName]).sort((a,b) => b[1] - a[1]);
      let print = '';
      result.forEach(w=> print+=`Name: ${w[0]} With Salary: ${w[1]} `)  
      document.querySelector('#bestRestaurant p').textContent = `Name: ${bestName} Average Salary: ${bestSalary.toFixed(2)} Best Salary: ${result[0][1].toFixed(2)}`;
      document.querySelector('#workers p').textContent = print; 

   }
}