type Applcants = {
    fname: string;
    lname: string;
    role: string;
    applicationDate: Date;
    interViewStart?: boolean;
    interViewDate?: Date;
    interViewEnd?: boolean;
    cleared?: boolean;
    hired?: boolean;
    joiningDate?: Date;
}

export var applicantData: Applcants[]=[];