import { useState } from 'react';

function Main() {
  const [loggedInUser, setLoggedInUser] = useState(localStorage.getItem('user'));

  const handleLogout = () => {
    // Clear the user from local storage and state
    localStorage.removeItem('user');
    setLoggedInUser(null);
  };

  const redirectToUserForm = () => {
    window.location.href = '/user-form';
  };

  if (loggedInUser) {
    return (
      <div>
        <p>Vítejte, {loggedInUser}!</p>
        <button onClick={handleLogout}>Odhlásit se</button>
      </div>
    );
  } else {
    return (
      <div>
        <p>Nepřihlášený uživatel</p>
        <button onClick={redirectToUserForm}>Přihlásit se</button>
      </div>
    );
  }
}

export default Main;