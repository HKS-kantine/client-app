import { Component, OnInit } from '@angular/core';
import {NotificationService} from '../../services/notificiation/notification.service';
import {Notification} from '../../models/notification';
import {ToastrService} from 'ngx-toastr';
import {not} from 'rxjs/internal-compatibility';

@Component({
  selector: 'app-notifications',
  templateUrl: './notifications.component.html',
  styleUrls: ['./notifications.component.css']
})
export class NotificationsComponent implements OnInit {

  notifications: Notification[];

  constructor(private notificationService: NotificationService, private toastr: ToastrService) {

  }

  ngOnInit(): void {
    this.notifications = this.notificationService.notifications;
    this.notifications.forEach(notificiation => {
      console.log(notificiation);
      switch (notificiation.type) {
        case 'info':
          this.toastr.info(notificiation.message, notificiation.title);
          break;
        case 'success':
        default:
          this.toastr.success(notificiation.message, notificiation.title);
          break;
      }

    });
  }


  removeNotification(notification: Notification) {
    this.notificationService.removeNotification(notification);
  }

}
