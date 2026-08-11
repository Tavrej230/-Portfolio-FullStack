import { Routes } from '@angular/router';
import { Home } from './pages/home/home';
import { About } from './pages/about/about';
import { Service } from './pages/service/service';
import { Projects } from './pages/projects/projects';
import { Education } from './pages/education/education';
import { Certificates } from './pages/certificates/certificates';
import { Contact } from './pages/contact/contact';

export const routes: Routes = [
  { path: '', component: Home },
  { path: 'about', component: About },
  { path: 'services', component: Service },
  { path: 'projects', component: Projects },
  { path: 'education', component: Education },
  { path: 'certificates', component: Certificates },
  { path: 'contact', component: Contact }
];
