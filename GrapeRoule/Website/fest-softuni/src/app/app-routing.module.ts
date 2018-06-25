import { NgModule } from "@angular/core";
import { RouterModule, Routes} from '@angular/router';
import { HomeComponent } from "./home/home.component";
import { WheelComponent } from "./wheel/wheel.component";
import { DownloadsComponent } from "./downloads/downloads.component";

const routes:Routes = [
    {path:'', component: HomeComponent},
    {path:'downloads', component: DownloadsComponent}
]

@NgModule({
    imports:[RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule {}