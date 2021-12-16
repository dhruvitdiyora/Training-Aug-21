export interface Restaurants  {
    restaurantId: number;
    resName: string;
};

export enum Times{
    fivePm=5,
    sixPm=6,
    sevenPm=7
};

export interface Tables {
    tableId: number;
    restaurantId: number;
    tableNumber: number;
    maxGuests: number;
};



export interface Reservations{
    reservationId: number;
    restaurantId: number;
    resName: string;
    tableNumber: number;
    times: number;
    maxGuests: number;
    date: Date;
    reserved: Boolean;
    token?: string;
}