import { GuiPosition } from '../enums/gui-position.enum';
import { GuiElement } from './gui-element';

export interface GuiSpecification {
    position: GuiPosition;
    width: number;
    height: number;
    guiElements: Array<GuiElement>;
}
