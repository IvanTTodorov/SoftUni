let { Repository } = require("./solution.js");
let expect = require('chai').expect;

describe("Repository", function () {
    let properties = {
        name: "string",
        age: "number",
        birthday: "object"
    };

    let entity = {
        name: "Pesho",
        age: 22,
        birthday: new Date(1998, 1, 7)
    };

    describe("Instantiation", function () {

        it("Should add properties on init", function () {

            let repository = new Repository(properties);

            expect(repository).to.have.property('props');
            expect(repository.props).to.deep.equal(properties);
        });
        it("Should have property data", function () {

            let repository = new Repository(properties);

            expect(repository).to.have.property('data');
            expect(typeof repository.data).is.equal('object');
            expect(repository.data).instanceOf(Map);
        });
    });

    describe('Get count', () => {
        it('Should return current count of entities in repository', () => {
            let repository = new Repository(properties);
            repository.add(entity);
            repository.add(entity);
            expect(repository.count).is.equal(2);
        })

        it('Should return zero if not added entities', () => {
            let repository = new Repository(properties);
            expect(repository.count).is.equal(0);
        })
    });

    describe('Add entity', () => {
        it('Should return id if the valid input is added', () => {
            let repository = new Repository(properties);

            expect(repository.add(entity)).to.equal(0);
            expect(repository.add(entity)).to.equal(1);
        });

        it('Should store valid entity in data map', () => {

            let repository = new Repository(properties);

            repository.add(entity);
            expect(repository.data.get(0)).not.to.be.undefined;
            expect(repository.data.get(0)).to.deep.equal(entity);

        })

        it('Should throw Error if property is missing', () => {

            let entity = {
                name: "Pesho",
                age: 22,
            };

            let repository = new Repository(properties);
            expect(() => repository.add(entity)).to.throw(Error, `Property birthday is missing from the entity`);
        })

        it('Should throw Error if property is of incorrect type', () => {
            let entity = {
                name: "Pesho",
                age: 22,
                birthday: "July"
            };
            let repository = new Repository(properties);
            expect(() => repository.add(entity)).to.throw(Error, "Property birthday is not of correct type!");
        })



    })

    describe('Get by Id', () => {

        it('Should return valid Id', () => {
            let repository = new Repository(properties);
            repository.add(entity);
            expect(repository.getId(0)).to.be.equal(entity);
        })
        it('Should return error because of invalid Id', () => {
            let repository = new Repository(properties);
            expect(() => repository.getId(0)).to.throw(Error, `Entity with id: 0 does not exist!`);
        })

    })
    describe('Update', () => {
        it('Should update the old entity by given id with new entity', () => {
            let newEntity = {
                name: 'Ivan',
                age: 23,
                birthday: new Date(1994, 1, 9)
            }
            let repository = new Repository(properties);
            repository.add(entity);
            repository.update(0, newEntity);

            expect(repository.getId(0).name).to.equal('Ivan');

        })
        it('Should throw an error because of invalid Id', () => {
        
            let newEntity = {
                name: 'Ivan',
                age: 23,
                birthday: new Date(1994, 1, 9)
            }
            let repository = new Repository(properties);
            repository.add(entity);
            expect(() => repository.update(1, newEntity)).to.throw(Error, "Entity with id: 1 does not exist!");
        })
    })
    describe('Delete', () => {
        it('Should delete the entity by id', () => {
            let repository = new Repository(properties);
            repository.add(entity);
            repository.del(0);
            expect(repository.count).is.equal(0);
        })
        it('Should return error because of invelid input', () => {
            let repository = new Repository(properties);
            repository.add(entity);
            expect(()=> repository.del(1)).to.throw(Error, "Entity with id: 1 does not exist!");
            
        })

    })
});

