import "../styles/authorization.css";
import { Link } from "react-router-dom";

const Authorization = () => {
    return (
        <div className="authorization-container">
            <h1 className="authorization-header">Авторизация</h1>
            <div className="input-authorization-container">
                <p>E-mail</p>
                <input type="text" className="input-authorization login" />
                <p>Пароль</p>
                <input type="password" className="input-authorization password" />
            </div>
            <button className="button-sign-in">Войти</button>
            <div className="link-container">
                <Link className="link-password-recovery" >Забыли пароль?</Link>
                <Link className="link-sign-up" to="/registration">Регистрация</Link>
            </div>
        </div>
    )
}

export default Authorization;