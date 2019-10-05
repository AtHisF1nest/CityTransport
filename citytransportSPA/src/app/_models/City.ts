import { Player } from './Player';

export interface City {
    id: number;
    name: string;
    created: Date;
    population: number;
    money: number;
    owner: Player;
}
