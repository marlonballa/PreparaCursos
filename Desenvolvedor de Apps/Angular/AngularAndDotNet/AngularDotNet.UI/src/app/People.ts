export class People {
    peopleId: string;
    namePeople: string;
    lastNamePeople: string;
    agePeople: number;
    professionPeople: string;

    constructor (peopleId: string, namePeople:string, lastNumberPeople:string, agePeople: number, professionPeople: string)
    {
        this.peopleId = peopleId,
        this.namePeople = namePeople,
        this.lastNamePeople = lastNumberPeople,
        this.agePeople = agePeople,
        this.professionPeople = professionPeople
    }
}