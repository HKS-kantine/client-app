import { Component, OnInit } from '@angular/core';
import {CollectionCallService} from '../../../services/collection-call/collection-call.service';
import {Order} from '../../../models/order';

@Component({
  selector: 'app-edit-order',
  templateUrl: './edit-order.component.html',
  styleUrls: ['./edit-order.component.css']
})
export class EditOrderComponent implements OnInit {

  products;

  constructor(private collectionCallService: CollectionCallService) { }

  ngOnInit(): void {
    this.collectionCallService.get('api/products').subscribe(res => {
      res.forEach(product => {
        product.amount = 0;
        product.updating = false;
      });
      this.products = res;
      console.log(res);

      this.collectionCallService.get('api/orderlist/1').subscribe(orderList => {
        orderList.orders.forEach(order => {
          const product = this.products.filter(p => p.id === order.product.id)[0];
          product.amount = order.amount;
          product.orderId = order.id;

        });
      });

    });
  }

  changeAmount(product, calculate = 1) {
    if ((product.amount + calculate) >= 0) {
      product.updating = true;
      product.amount += calculate;

      const order: Order = {
        product: product,
        amount: product.amount,
        orderList: 1
      };
      console.log(order);
      if (product.orderId) {
        order.id = product.orderId;
      }
      this.collectionCallService.post('api/order', order).subscribe(res => {
        product.updating = false;
      }, error => {
        product.amount -= calculate;
        product.updating = false;
      });
      // product.updating = false;
    }

  }

}
