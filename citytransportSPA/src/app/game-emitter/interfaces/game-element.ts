import { ImageElement } from './image-element';
import { EventElement } from './event-element';
import { KeyValue } from '@angular/common';

export interface GameElement {
    name: string;
    xCord: number;
    yCord: number;
    gridWidth: number;
    gridHeight: number;
    imageElement: ImageElement;
    childGameElement: GameElement;
    events: Array<EventElement>;
    styles: Array<KeyValue<string, string>>;
}
