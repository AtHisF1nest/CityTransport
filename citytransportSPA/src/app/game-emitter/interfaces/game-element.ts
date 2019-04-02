import { ImageElement } from './image-element';

export interface GameElement {
    name: string;
    xCord: number;
    yCord: number;
    gridWidth: number;
    gridHeight: number;
    imageElement: ImageElement;
    childGameElement: GameElement;
}
