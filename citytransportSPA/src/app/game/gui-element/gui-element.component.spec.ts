/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { GuiElementComponent } from './gui-element.component';

describe('GuiElementComponent', () => {
  let component: GuiElementComponent;
  let fixture: ComponentFixture<GuiElementComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GuiElementComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GuiElementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
