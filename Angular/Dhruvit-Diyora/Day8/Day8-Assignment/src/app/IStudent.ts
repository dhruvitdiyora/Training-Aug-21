export interface IStudent {
    FirstName: String;
    MiddleName: String;
    LastName: String;
    Dob: String;
    PlaceOfBirth: String;
    FirstLanguage: String;
    Address: Address;
    Father: Father;
    Mother: Mother;

    EmergancyContactList: EmergancyContactList[];
    References: References[];



}
type Address = {
    City: String;
    State: String;
    Country: String;
    Pin: String;
};
type Father = {
    FFirstName: String;
    FMiddleName: String;
    FLastName: String;
    FEmail: String;
    FQualification: String;
    FProfession: String;
    FDesignation: String;
    FPhone: String;
};
type Mother = {
    MFirstName: String;
    MMiddleName: String;
    MLastName: String;
    MEmail: String;
    MQualification: String;
    MProfession: String;
    MDesignation: String;
    MPhone: String;
}

type EmergancyContactList = { Relation: String, Number: String };
type References = {


    ReferenceThrough: String,
    Address: String,
    RefsNumber: String
}
