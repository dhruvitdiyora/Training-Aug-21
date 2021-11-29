import * as models from "./model";

var restaurants: Array<models.Restaurants> = [{restaurantId:1,resName:"res1"},{restaurantId:2,resName:"res2"},{restaurantId:3,resName:"res3"}];
var tables: Array<models.Tables> = [{tableId:1,restaurantId:1,tableNumber:1,maxGuests:4},{tableId:2,restaurantId:1,tableNumber:2,maxGuests:8},{tableId:3,restaurantId:1,tableNumber:3,maxGuests:2},{tableId:4,restaurantId:2,tableNumber:1,maxGuests:4},{tableId:5,restaurantId:2,tableNumber:2,maxGuests:8},{tableId:6,restaurantId:2,tableNumber:3,maxGuests:1},{tableId:7,restaurantId:2,tableNumber:4,maxGuests:4},{tableId:8,restaurantId:3,tableNumber:1,maxGuests:4}];

var reservations: Array<models.Reservations> = [];


class system{
    constructor() {
        this.set("11/25/2021");
    }
    
    GetRest(): void{
        console.log("Hello, Greeting\n");
        console.log("Showing all");
        restaurants.forEach(rest => {
            console.log(`Restaurant Name: ${rest.resName} and Restaurant Id: ${rest.restaurantId}`);
        });
    }
    ShowTables(restId: number, resDate: Date): void{
        var rese = reservations.filter(function (re) {  
            return re.restaurantId == restId && re.date == resDate;
        });
        rese.forEach(reserve => {
            if (reserve.restaurantId == restId && reserve.date == resDate && !reserve.reserved) {
                console.log(`Restaurant Name: ${reserve.resName} and Restaurant Id: ${reserve.restaurantId}\n`);
                console.log(`Table Number: ${reserve.tableNumber}, Maximum people can seat on table ${reserve.tableNumber} : ${reserve.maxGuests} and for time is ${this.GetTime(reserve.times)}`);
                console.log(`reservation id is ${reserve.reservationId}`); 
            }
        });
    }
    ReserveTable(reserveId: number): void{
        var r = reservations.find(function (re) {  
            return re.reservationId == reserveId;  
        });
        if (r.reserved) {
            console.log("Table already booked");
        }
        else {
            r.reserved = true;
            r.token = this.GetToken();
            console.log("table is booked, thank you \n");
            console.log(`token id is ${r.token}`);
        }
        
    }
    GetToken(): string{
        return Math.random().toString(36).substr(2, 12);
    }
    set(d:string) {

        restaurants.forEach(rest => {
            var rTable = tables.filter(function (re) {  
                return re.restaurantId == rest.restaurantId;  
            });
            rTable.forEach(tab => {
                for (var i in models.Times) {
                    reservations.push({reservationId:new Date().getTime(),restaurantId:rest.restaurantId,resName:rest.resName,tableNumber:tab.tableNumber,times:Number(i),maxGuests:tab.maxGuests,date:new Date(d),reserved:false});
                    
                }
                Object.values(models.Times).forEach((value) => {
                    console.log(value.valueOf());
                });
            });
        });
    }
    GetTime(time:number): string{
        return `${time} to ${time + 1}`;
    }
    
}

var reserve = new system();
reserve.GetRest();
reserve.ShowTables(3, new Date("11/25/2021"));
reserve.ReserveTable(368235);

//tsc --module amd --target es2017 app.ts
