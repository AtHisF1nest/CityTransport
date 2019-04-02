import { WindowSpecification } from './window-specification';
import { GuiSpecification } from './gui-specification';
import { AssetsSpecification } from './assets-specification';
import { ElementsSpecification } from './elements-specification';

export interface GameContainer {
    windowSpec: WindowSpecification;
    guiSpec: GuiSpecification;
    assetsSpec: AssetsSpecification;
    elementsSpec: ElementsSpecification;
}
