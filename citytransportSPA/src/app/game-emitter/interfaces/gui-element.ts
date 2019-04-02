import { EventElement } from './event-element';

export interface GuiElement {
    name: string;
    style: string;
    class: string;
    events: Array<EventElement>;
}
