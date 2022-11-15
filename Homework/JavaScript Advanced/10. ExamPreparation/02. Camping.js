class SummerCamp {
    constructor(organizer, location, priceForTheCamp) {
        this.organizer = organizer;
        this.location = location;
        this.priceForTheCamp = { "child": 150, "student": 300, "collegian": 500 }
        this.listOfParticipants = [];
    }

    registerParticipant(name, condition, money) {

        let participant = {
            name,
            condition,
            power: 100,
            wins: 0
        };

        if (!this.priceForTheCamp[condition]) {
            throw new Error ('Unsuccessful registration at the camp.');
        }

        if (money < this.priceForTheCamp[condition]) {
            return `The money is not enough to pay the stay at the camp.`
        }

        if (this.listOfParticipants.some(x => x.name == name)) {
            return `The ${name} is already registered at the camp.`;
        } else {
            this.listOfParticipants.push(participant);
            return `The ${name} was successfully registered.`
        }

    }

    unregisterParticipant(name) {
        if (!this.listOfParticipants.some(x => x.name == name)) {
            throw new Error(`The ${name} is not registered in the camp.`)
        } else {
            this.listOfParticipants.pop(x => x.name == name);
            return `The ${name} removed successfully.`
        }
    } 

    timeToPlay(typeOfGame, participant1, participant2) {
            let player1 = this.listOfParticipants.find(x => x.name == participant1); 
        if (!player1) {
            throw new Error(`Invalid entered name/s.`);
        }

        if (typeOfGame === 'Battleship') {
           

            player1.power += 20;
            return `The ${player1.name} successfully completed the game ${typeOfGame}.`

        } else if (typeOfGame == 'WaterBalloonFights') {
            let player2 = this.listOfParticipants.find(x => x.name == participant2); 

            if (!player2) {
                throw new Error(`Invalid entered name/s.`);
            }


            if (player1.condition != player2.condition) {
                throw new Error (`Choose players with equal condition.`);
            } else {
                if (player1.power > player2.power) {
                    player1.wins += 1;
                    return `The ${player1.name} is winner in the game ${typeOfGame}.`
                } else if (player1.power < player2.power) {
                    part2.wins += 1;
                    return `The ${player2.name} is winner in the game ${typeOfGame}.`
                } else {
                    return `There is no winner.`;
                }
            }

        }

    }
    toString() {
     let result = [`${this.organizer} will take ${this.listOfParticipants.length} participants on camping to ${this.location}`];
     
     this.listOfParticipants.sort((a,b) => b.wins - a.wins)
     this.listOfParticipants.forEach((e) => result.push(`${e.name} - ${e.condition} - ${e.power} - ${e.wins}`));
        return result.join('\n')
     }

    } 


    const summerCamp = new SummerCamp("Jane Austen", "Pancharevo Sofia 1137, Bulgaria");
    console.log(summerCamp.registerParticipant("Petar Petarson", "student", 300));
    console.log(summerCamp.registerParticipant("Sara Dickinson", "child", 200)); 
    console.log(summerCamp.unregisterParticipant("Sara Dickinson", "child", 200)); 

    






