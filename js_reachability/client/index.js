import 'moment/locale/de';
import logoUrl from '!!file-loader!./assets/logo.png';
import { isValidEmail } from './api';

document.querySelector('#logo').src = logoUrl;
document.querySelector('#email').addEventListener('change', (event) => {
  event.target.classList.toggle('invalid', !isValidEmail(event.target.value));
});
