import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './modules/home/home.component';
import { RegiaoFormComponent } from './components/regiao-form/regiao-form.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: '/home',
    pathMatch: 'full'
  },
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: 'regiao',
    loadChildren: () => import('./modules/regiao/regiao.module').then(m => m.RegiaoModule)
  },
  { 
    path: 'regiao/adicionar', 
    component: RegiaoFormComponent 
  },
  { 
    path: 'regiao/editar/:id', 
    component: RegiaoFormComponent 
  },
  { 
    path: '**', 
    redirectTo: '/home' 
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
