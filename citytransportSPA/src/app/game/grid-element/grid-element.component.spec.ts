/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { GridElementComponent } from './grid-element.component';

describe('GridElementComponent', () => {
  let component: GridElementComponent;
  let fixture: ComponentFixture<GridElementComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GridElementComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GridElementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
