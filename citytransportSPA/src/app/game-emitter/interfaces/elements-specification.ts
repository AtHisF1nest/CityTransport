import { GameElement } from './game-element';

export interface ElementsSpecification {
    grid: Array<GameElement>;
    gridWidth: number;
    gridHeight: number;
}
