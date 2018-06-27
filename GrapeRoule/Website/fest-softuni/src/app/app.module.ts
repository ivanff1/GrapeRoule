import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { WheelComponent } from './wheel/wheel.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MzButtonModule, MzNavbarComponent, MzNavbarModule} from 'ng2-materialize';
import { CoreComponent } from './core/core.component';
import { HomeComponent } from './home/home.component';
import { AppRoutingModule } from './app-routing.module';
import { DownloadsComponent } from './downloads/downloads.component';
import {HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    WheelComponent,
    CoreComponent,
    HomeComponent,
    DownloadsComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MzButtonModule,
    MzNavbarModule,
    // AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
