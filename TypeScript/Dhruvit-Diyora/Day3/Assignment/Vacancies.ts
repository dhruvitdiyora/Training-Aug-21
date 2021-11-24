 type vacancy = {
    role: string;
    experience: string;
    minSalary: number;
    maxSalary: number;
    location: string;
    joining: string;
    technology: string;
}
var vacancyData: vacancy[]=[];
export class vacancies{
    public AddVacancy(rol: string, exp: string, minS: number, maxS: number, loc: string, join: string, tech: string): void{
        try {
            vacancyData.push({ role: rol, experience: exp, minSalary: minS, maxSalary: maxS, location: loc, joining: join, technology: tech });
            console.log("VacancyData Added");
        }
        catch (e) {
            console.error(e);
        }
    }
    public ShowVacancy(): void{
        vacancyData.forEach(vacant => {
            console.log(`Hello job seeker\n we are having an opening for ${vacant.role} \n in ${vacant.technology} technology with minimum experience of ${vacant.experience} , expected salary is between ${vacant.minSalary}  to ${vacant.maxSalary} ,\n location is ${vacant.location} \n `);
                       
        });
    }
}