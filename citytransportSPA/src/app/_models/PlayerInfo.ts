import { Player } from './Player';
import { City } from './City';
import { Vehicle } from './Vehicle';

export interface PlayerInfo {
    player?: Player;
    currentCity?: City;
    availableVehicles?: Array<Vehicle>;
}
