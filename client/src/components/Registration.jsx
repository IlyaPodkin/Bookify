import "../styles/registration.css";
import { Link } from "react-router-dom";

const Registration = () => {
    return (
        <div className="registration-container">
            <h1 className="registration-header">Регистрация</h1>
            <div className="input-container">
                <p>E-mail</p>
                <input type="text" className="login-input" />
                <p>Пароль</p>
                <input type="password" className="password-input" />
                <p>Повторите пароль</p>
                <input type="password" className="password-input" />
            </div>
            <button className="button-sign-up">Зарегистрироваться</button>
            <div className="link-container">
                <Link className="link-sign-in" to="/authorization">Авторизация</Link>
            </div>
        </div>
    )
}

export default Registration;