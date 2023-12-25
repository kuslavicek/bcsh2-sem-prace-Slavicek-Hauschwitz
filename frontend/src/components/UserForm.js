import React, { useState } from 'react';

function UserForm({ setUser }) {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');

  const handleLogin = async (e) => {
    e.preventDefault();

    const response = await fetch(`http://localhost:7043/api/user/login?username=${username}&password=${password}`, {
      method: 'POST',
      mode: 'cors'
    });

    const data = await response.json();

    if (response.ok) {
      localStorage.setItem('user', JSON.stringify(data.user));
      setUser(data.user);
    } else {
      alert('Login failed');
    }
  };
  const handleRegister = async (e) => {
    e.preventDefault();

    const response = await fetch(`http://localhost:7043/api/user/register?username=${username}&password=${password}`, {
      method: 'POST',
      mode: 'cors'
    });

    const data = await response.json();

    if (response.ok) {
      localStorage.setItem('user', JSON.stringify(data.user));
      setUser(data.user);
    } else {
      alert('Login failed');
    }
  };

  return (
    <form>
      <input
        type="text"
        placeholder="Uživatelské jméno"
        value={username}
        onChange={(e) => setUsername(e.target.value)}
      />
      <input
        type="password"
        placeholder="Heslo"
        value={password}
        onChange={(e) => setPassword(e.target.value)}
      />
      <button onclick={handleLogin}>Přihlásit se</button>
      <button onclick={handleRegister}>Registrovat</button>
    </form>
  );
}

export default UserForm;