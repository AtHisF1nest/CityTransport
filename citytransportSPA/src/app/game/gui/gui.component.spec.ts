/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { GuiComponent } from './gui.component';

describe('GuiComponent', () => {
  let component: GuiComponent;
  let fixture: ComponentFixture<GuiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GuiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GuiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
