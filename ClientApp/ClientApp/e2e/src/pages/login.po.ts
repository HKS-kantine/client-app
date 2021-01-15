import { browser, by, element } from 'protractor';

export class LoginPage {
  navigateTo() {
    return browser.get('/login');
  }

  SetUser(user) {
    element(by.css('input[name="username"]')).sendKeys(user);
  }

  SetPassword(pass) {
    element(by.css('input[name="password"]')).sendKeys(pass);
  }

  getWrongUser() {
    this.SetUser('wrong');
    this.SetPassword('wrong');

    element(by.css('btn btn-primary my-4')).click();

    const alert = browser.switchTo().alert();

    return alert;
  }

  getCorrectUser() {
    this.SetUser('maarten.jakobs@gmail.com');
    this.SetPassword('sonu@123');

    element(by.css('btn btn-primary my-4')).click();

    return true;
  }
  getParagraphText() {
    return element(by.css('app-root h1')).getText();
  }
}
