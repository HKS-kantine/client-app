import { Routes } from '@angular/router';

import { DashboardComponent } from '../../pages/dashboard/dashboard.component';
import { UserProfileComponent } from '../../pages/user-profile/user-profile.component';
import {MyOrdersComponent} from '../../pages/my-orders/my-orders.component';
import {PeatComponent} from '../../pages/peat/peat.component';
import {EditOrderComponent} from '../../pages/peat/edit-order/edit-order.component';

export const AdminLayoutRoutes: Routes = [
    { path: 'dashboard',      component: DashboardComponent },
    { path: 'bestellingen',   component: MyOrdersComponent },
    { path: 'lappen',   component: UserProfileComponent },
    { path: 'turven',   component: PeatComponent },
    { path: 'turven/:id/bestelling',   component: EditOrderComponent },
    { path: 'profiel',   component: UserProfileComponent }
];
