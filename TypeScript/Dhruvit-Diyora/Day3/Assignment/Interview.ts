import { applicantData } from "./ApplicantData";

export class Interview{
    public StartInterview(startedName:string[]) {
        startedName.forEach(element => {
            applicantData.forEach(appl => {
                if (appl.fname == element) {
                    appl.interViewDate = new Date();
                    appl.interViewStart = true;
                }
            });
            
        });
    }
    public EndInterview(endName:string[]) {
        endName.forEach(element => {
            applicantData.forEach(appl => {
                if (appl.fname == element) {
                    appl.interViewEnd = true;
                }
            });
            
        });
    }
    public HireApplicant(hireedName:string[]) {
        hireedName.forEach(element => {
            applicantData.forEach(appl => {
                if (appl.fname == element) {
                    appl.hired = true;
                    appl.joiningDate = new Date();
                }
            });
            
        });
    }
    public ClearApplicant(clearedName:string[]) {
        clearedName.forEach(element => {
            applicantData.forEach(appl => {
                if (appl.fname == element) {
                    appl.cleared = true;
                }
            });
            
        });
    }
}