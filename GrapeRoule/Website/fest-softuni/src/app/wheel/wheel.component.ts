import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';

@Component({
  selector: 'app-wheel',
  templateUrl: './wheel.component.html',
  styleUrls: ['./wheel.component.css']
})
export class WheelComponent implements OnInit {
  @ViewChild('canvas') canvas:ElementRef<HTMLCanvasElement>;
  ctx:CanvasRenderingContext2D;
  x:number;
  h:number;
  w:number;
  cH:number;
  y:number;
  colors = ['#FF0000', '#00FF00', '#0000FF', '#0F0F0F', '#DD0000'];
  i=0;
  j=0;
  v = 2;
  constructor() { }

  ngOnInit() {
    this.canvas.nativeElement.width = 200;
    this.canvas.nativeElement.height= 200;
    this.ctx = this.canvas.nativeElement.getContext("2d");
    this.x=20;
    this.cH=200;
    this.y = 20;
    this.w = 100;
    this.h=100;
    this.ctx.fillRect(this.x,this.y,this.w,this.h);
    let inter = setInterval(this.draw.bind(this), 1000/60);
    // setTimeout(setInterval(() =>{
    //   this.v--;
    //   if (0== this.v) {
    //     console.log("stopped")
    //     clearInterval(inter);
    //   }

    // }, 500),3000)
  }

  draw() {
    // console.log(iter);
    this.ctx.clearRect(0,0,200,200);
    this.y+=this.v;
    let color2 = this.colors[this.i+1];
    let color1= this.colors[this.i];
    if (color2 == undefined && color1 != undefined) {
      color2 = this.colors[0];
    }
    if (color1 == undefined && color2 == undefined) {
      this.i=0;
      color2 = this.colors[this.i+1];
      color1= this.colors[this.i];
    }
    this.ctx.fillStyle= color1;
    this.ctx.fillRect(this.x, this.y, this.w, this.h); 
    if (this.cH - (this.y+ this.h) <0) {
    
      this.ctx.fillStyle = color2;
      // console.log(color2, color1);
      // this.ctx.fillRect(this.x, Math.abs((this.cH - (this.y+ this.h))) -this.h, this.w, this.h);
      this.ctx.fillRect(this.x, Math.abs((this.cH - (this.y+ this.h))) -this.h, this.w, this.h);

      this.ctx.fillStyle = color1;
      
    }
    if (this.y>=this.cH) {
      this.i++;
      this.y-=this.cH;
    }

  }

}
