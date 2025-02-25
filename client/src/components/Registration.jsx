import "../styles/registration.css";
import { Link } from "react-router-dom";
import axios from "axios";
import React, {useState} from "react";

const Registration = () => {

    const [userName, setUserName] = useState("");
    const [userPhone, setUserPhone] = useState("");
    const [userEmail, setUserEmail] = useState("");
    const [userPassword, setUserPassword] = useState("");
    const [userRepeatPassword, setUserRepeatPassword] = useState("");
    const API_URL = process.env.REACT_APP_API_URL;

    const sendUserdata = () =>
        {
            axios.post(`${API_URL}user`, {name:userName,phoneNumber:userPhone,email:userEmail,password:userPassword})
            .then((response) => {
                console.log(`Данные добавлены:`, response.data);
                setUserName("");
                setUserPhone("");
                setUserEmail("");
                setUserPassword("");
                setUserRepeatPassword("");
            })
            .catch((error) => {
                console.error(`Ошибка при запросе:`, error);
            });
        };

    return (
        <div className="registration-container">
            <h1 className="registration-header">Регистрация</h1>
            <div className="input-registration-container">
                <p>Фамилия/Имя</p>
                <input type="text" className="input-registration name" value={userName}
                onChange={(e) => setUserName(e.target.value)}/>
                <p>Номер телефона</p>
                <input type="text" className="input-registration phone" value={userPhone}
                onChange={(e) => setUserPhone(e.target.value)}/>
                <p>E-mail</p>
                <input type="text" className="input-registration login" value={userEmail}
                onChange={(e) => setUserEmail(e.target.value)}/>
                <p>Пароль</p>
                <input type="password" className="input-registration password" value={userPassword}
                onChange={(e) => setUserPassword(e.target.value)}/>
                <p>Повторите пароль</p>
                <input type="password" className="input-registration repead-password" value={userRepeatPassword}
                onChange={(e) => setUserRepeatPassword(e.target.value)}/>
            </div>
            <button className="button-sign-up" onClick={sendUserdata}>Зарегистрироваться</button>
            <div className="link-container">
                <Link className="link-sign-in" to="/authorization">Авторизация</Link>
            </div>
        </div>
    )
}

export default Registration;