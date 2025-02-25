import "../styles/registration.css";

const Registration = () => {
    return (
        <div className="authorization-container">
            <h1 className="authorization-header">Авторизация</h1>
            <div>
                <p>E-mail</p>
                <input type="text" className="login-input" />
                <p>Пароль</p>
                <input type="password" className="password-input" />
            </div>
            <button className="button-sign-in">Войти</button>
            <div className="link-container">
                <a className="link-password-recovery" href="">Забыли пароль?</a>
                <a className="link-sign-up" href="">Регистрация</a>
            </div>
        </div>
    )
}

export default Registration;