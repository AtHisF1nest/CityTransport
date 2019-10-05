import { ElementType } from '../enums/element-type';

export interface MapField {
    name: string;
    xCord: number;
    yCord: number;
    gridWidth: number;
    gridHeight: number;
    photoPath: string;
    elementType: ElementType;
}
