import { applicantData } from "./ApplicantData";

export class Applicants{
    public addApplicants(fname: string, lname: string, role:string): void{
        try {
            applicantData.push({ fname: fname, lname: lname, role: role, applicationDate:new Date()});
            console.log("Application Submitted");
        }
        catch (e) {
            console.error(e);
        }
    }
    public ShowApplicants(): void{
        console.log("applicant list");
        console.log(applicantData)
    }
}