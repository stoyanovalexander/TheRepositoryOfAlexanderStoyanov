var ui = (function () {

    function buildLoginForm() {
        var html =
            '<div id="login-form-holder">' +
				'<form>' +
					'<div id="login-form">' +
						'<label for="tb-login-username">Username: </label>' +
						'<input type="text" id="tb-login-username"><br />' +
						'<label for="tb-login-password">Password: </label>' +
						'<input type="text" id="tb-login-password"><br />' +
						'<button id="btn-login" class="button">Login</button>' +
					'</div>' +
					'<div id="register-form" style="display: none">' +
						'<label for="tb-register-username">Username: </label>' +
						'<input type="text" id="tb-register-username"><br />' +
						'<label for="tb-register-nickname">Nickname: </label>' +
						'<input type="text" id="tb-register-nickname"><br />' +
						'<label for="tb-register-password">Password: </label>' +
						'<input type="text" id="tb-register-password"><br />' +
						'<button id="btn-register" class="button">Register</button>' +
					'</div>' +
					'<a href="#" id="btn-show-login" class="button selected">Login</a>' +
					'<a href="#" id="btn-show-register" class="button">Register</a>' +
				'</form>' +
            '</div>';
        return html;
    }

    function buildGameUI(nickname) {
    	var html = '<span id="user-nickname">' +
    			nickname +
    	'</span>' +
    	'<button id="btn-logout">Logout</button><br/>' +
    	'<div id="create-game-holder">' +
    		'Title: <input type="text" id="tb-create-title" />' +
    		'Password: <input type="text" id="tb-create-pass" />' +
    		'Number: <input type="text" id="tb-create-number" />' +
    		'<button id="btn-create-game">Create</button>' +
    	'</div>' +
    	'<div id="open-games-container">' +
    		'<h2>Open</h2>' +
    		'<div id="open-games"></div>' +
    	'</div>' +
    	'<div id="active-games-container">' +
    		'<h2>Active</h2>' +
    		'<div id="active-games"></div>' +
    	'</div>' +
    	'<div id="game-holder">' +
    	'</div>';
    	return html;
    }
    return {
        gameUI: buildGameUI,
        loginForm: buildLoginForm
    }

}());