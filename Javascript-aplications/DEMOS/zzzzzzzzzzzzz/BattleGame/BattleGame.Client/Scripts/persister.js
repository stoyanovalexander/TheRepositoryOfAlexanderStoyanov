﻿/// <reference path="http-requester.js" />
/// <reference path="class.js" />
/// <reference path="http://crypto-js.googlecode.com/svn/tags/3.1.2/build/rollups/sha1.js" />
var persisters = (function () {
    var nickname = localStorage.getItem("nickname");
    var sessionKey = localStorage.getItem("sessionKey");
    function saveUserData(userData) {
        localStorage.setItem("nickname", userData.nickname);
        localStorage.setItem("sessionKey", userData.sessionKey);
        nickname = userData.nickname;
        sessionKey = userData.sessionKey;
    }
    function clearUserData() {
        localStorage.removeItem("nickname");
        localStorage.removeItem("sessionKey");
        nickname = "";
        sessionKey = "";
    }

    var MainPersister = Class.create({
        init: function (rootUrl) {
            this.rootUrl = rootUrl;
            this.user = new UserPersister(this.rootUrl);
            this.game = new GamePersister(this.rootUrl);
        },
        isUserLoggedIn: function () {
            var isLoggedIn = nickname != null && sessionKey != null;
            return isLoggedIn;
        },
        nickname: function () {
            return nickname;
        }
    });
    var UserPersister = Class.create({
        init: function (rootUrl) {
            this.rootUrl = rootUrl + "user/";
        },
        login: function (user, success, error) {
            var url = this.rootUrl + "login";
            var userData = {
                username: user.username,
                authCode: CryptoJS.SHA1(user.username + user.password).toString()
            };

            httpRequester.postJSON(url, userData,
				function (data) {
				    saveUserData(data);
				    success(data);
				}, error);
        },
        register: function (user, success, error) {
            var url = this.rootUrl + "register";
            var userData = {
                username: user.username,
                nickname: user.nickname,
                authCode: CryptoJS.SHA1(user.username + user.password).toString()
            };
            httpRequester.postJSON(url, userData,
				function (data) {
				    saveUserData(data);
				    success(data);
				}, error);
        },
        logout: function (success, error) {
            var url = this.rootUrl + "logout/" + sessionKey;
            httpRequester.getJSON(url, function (data) {
                clearUserData();
                success(data);
            }, error)
        },
        scores: function (success, error) {
        }
    });
    var GamePersister = Class.create({
    	init: function (url) {
    		this.rootUrl = url + "game/";
    	},
    	create: function (game, success, error) {
    		var gameData = {
    			title: game.title,
    			number: game.id
    		};
    		if (game.password) {
    			gameData.password = CryptoJS.SHA1(game.password).toString();
    		}
    		var url = this.rootUrl + "create/" + sessionKey;
    		httpRequester.postJSON(url, gameData, success, error);
    	},
    	join: function (game, success, error) {
    		var gameData = {
    			gameId: game.id,
    			number: game.number
    		};
    		if (game.password) {
    			gameData.password = CryptoJS.SHA1(game.password).toString();
    		}
    		var url = this.rootUrl + "join/" + sessionKey;
    		httpRequester.postJSON(url, gameData, success, error);
    	}
    });
    
    return {
        get: function (url) {
            return new MainPersister(url);
        }
    };
}());