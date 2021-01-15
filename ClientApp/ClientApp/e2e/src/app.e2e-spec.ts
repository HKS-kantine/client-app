import { AppPage } from './app.po';
import {LoginPage} from './pages/login.po';

// describe('workspace-project App', () => {
//   let page: AppPage;
//
//   beforeEach(() => {
//     page = new AppPage();
//   });
//
//   it('should display welcome message', () => {
//     page.navigateTo();
//     expect(page.getParagraphText()).toEqual('Welcome to argon-dashboard-angular!');
//   });
// });

describe('Login page', () => {
  let page: LoginPage;

  beforeEach(() => {
    page = new LoginPage();
  });

  it('shouldnt log in', () => {
    page.navigateTo();

    expect(page.getWrongUser);
  });

  it('should log in', () => {
    page.navigateTo();

    expect(page.getCorrectUser);
  });
});
