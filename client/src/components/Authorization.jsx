import "../styles/authorization.css";

const Authorization = () => {
    return(
        <div className="authorization-container">
            <h1 className="authorization-header">Авторизация</h1>
            <p>E-mail</p>
            <input type="text" className="login-input"/>
            <p>Пароль</p>
            <input type="password" className="password-input"/>
            <button className="button-sign-in">Войти</button>
            <div className="link-container">
            <a className="link-password-recovery" href="">Забыли пароль?</a>
            <a className="link-sign-up" href="">Регистрация</a>
            </div>
        </div>
    )
}

export default Authorization;