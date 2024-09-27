import { ProDiegoV1TemplatePage } from './app.po';

describe('ProDiegoV1 App', function() {
  let page: ProDiegoV1TemplatePage;

  beforeEach(() => {
    page = new ProDiegoV1TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
