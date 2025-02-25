import "../styles/registration.css";

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
            <button className="button-sign-in">Войти</button>
            <div className="link-container">
                <a className="link-sign-up" href="">Авторизация</a>
            </div>
        </div>
    )
}

export default Registration;