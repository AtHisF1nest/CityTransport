import { EventType } from '../enums/event-type.enum';

export interface EventElement {
    eventType: EventType;
    eventFunction: any;
}
