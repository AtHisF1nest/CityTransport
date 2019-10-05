import { VehicleType } from '../_enums/vehicle-type.enum';
import { Player } from './Player';

export interface Vehicle {
    id: number;
    vehicleType: VehicleType;
    cost: number;
    speed: number;
    capacity: number;
    fuel: number;
    owner: Player;
    sourcePath: string;

    //not in dto
    isSelected?: boolean;
}
