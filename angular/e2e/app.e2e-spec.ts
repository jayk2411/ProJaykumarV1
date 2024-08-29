import { ProJaykumarV1TemplatePage } from './app.po';

describe('ProJaykumarV1 App', function() {
  let page: ProJaykumarV1TemplatePage;

  beforeEach(() => {
    page = new ProJaykumarV1TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
