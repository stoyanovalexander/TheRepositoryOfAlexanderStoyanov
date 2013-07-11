/// <reference path="q.js" />
/// <reference path="jquery-2.0.2.js" />
/// <reference path="http-requester.js" />
/// <reference path="class.js" />
var BullsAndCows = BullsAndCows || {}

BullsAndCows.UI = (function () {
    var buildControlPromise = function (controlHtmlUrl, rootElement) {
        var buildDeferred = Q.defer();

        HttpRequester.getJson(controlHtmlUrl).then(function (partialHtml) {
            var container = $("<div class='control-container'>" + partialHtml + "</div>");
            $(rootElement).append(container);
            rootElement = container;

            buildDeferred.resolve(rootElement);
        }, function (error) {
            buildDeferred.reject(error);
        });

        return buildDeferred.promise;
    }

    var LoginControl = Class.create({
        build: function (selector) {
            var self = this;
            self.rootElement = $(selector);

            return buildControlPromise("../login-control.html", this.rootElement).then(function (newRootElement) {
                self.rootElement = newRootElement;
            });
        },

        getUsernameText: function () {
            return $("#login-username-input").val();
        },

        getPasswordText: function () {
            return $("#login-password-input").val();
        },

        attachLoginClickHandler: function (handler, removePreviousHandlers) {

            var self = this;

            if (removePreviousHandlers) {
                $(this.rootElement).off("click");
            }

            this.rootElement.on("click", "#login-button", function () {
                var loginData = {
                    username: self.getUsernameText(),
                    password: self.getPasswordText()
                };

                handler(loginData);
            });
        },

        reportError: function (errorMessage) {
            this.rootElement.append("<p class='error-message' style='color:red'>" + errorMessage + "</p>");
        }
    });

    var RegisterControl = Class.create({
        build: function (selector) {
            var self = this;
            self.rootElement = $(selector);

            return buildControlPromise("../register-control.html", this.rootElement).then(function (newRootElement) {
                self.rootElement = newRootElement;
            });
        },

        getUsernameText: function () {
            return $("#register-username-input").val();
        },

        getPasswordText: function () {
            return $("#register-password-input").val();
        },

        getNicknameText: function () {
            return $("#register-nickname-input").val();
        },

        attachRegisterClickHandler: function (handler, removePreviousHandlers) {
            var self = this;

            if (removePreviousHandlers) {
                $(this.rootElement).off("click");
            }

            $(this.rootElement).on("click", "#register-button", function () {
                var registerData = {
                    username: self.getUsernameText(),
                    nickname: self.getNicknameText(),
                    password: self.getPasswordText()
                };

                handler(registerData);
            });
        },

        reportError: function (errorMessage) {
            this.rootElement.append("<p class='error-message' style='color:red'>" + errorMessage + "</p>");
        }
    });

    var ListControl = Class.create({
        build: function (selector, header, data, dataDisplayPropertyName) {

            var self = this;
            self.rootElement = $(selector);
            self.listElements = new Array();

            return buildControlPromise("../list-control.html", this.rootElement).then(function (newRootElement) {
                self.rootElement = newRootElement;

                self.header = self.rootElement.children("h2.control-header"),
                self.listContainer = self.rootElement.children("ul.control-data-container");

                self.header.text(header);

                self.changeData(data, dataDisplayPropertyName);
            });
        },

        changeData: function (newData, dataDisplayPropertyName) {
            this.listContainer.html("");

            if (newData) {
                for (var i in newData) {
                    var listElement = $("<li>" + newData[i][dataDisplayPropertyName] + "</li>");

                    this.listContainer.append(listElement);

                    this.listElements.push(listElement);
                }
            }
        },

        attachItemClickHandler: function (handler, removePreviousHandlers) {
            var self = this;

            if (removePreviousHandlers) {
                $(this.rootElement).off("click");
            }

            self.rootElement.on("click", "li", function (event) {
                var itemData = {
                    itemIndex: $(this).index(),
                    item: $(this)
                }
                handler(itemData);
            })
        }
    });

    var creategamecontrol = class.create({
        build: function (selector) {
            var self = this;
            self.rootelement = $(selector);

            return buildcontrolpromise("../create-game-control.html", this.rootelement).then(function (newrootelement) {
                self.rootelement = newrootelement;
            });
        },

        gettitletext: function () {
            return $("#create-game-title-input").val();
        },

        getnumbertext: function () {
            return $("#create-game-number-input").val();
        },

        getpasswordtext: function () {
            return $("#create-game-password-input").val();
        },

        attachcreateclickhandler: function (handler, removeprevioushandlers) {

            var self = this;

            if (removeprevioushandlers) {
                $(this.rootelement).off("click");
            }

            $(this.rootelement).on("click", "#create-game-button", function () {
                var gamecreatedata = {
                    title: self.gettitletext(),
                    password: self.getpasswordtext(),
                    number: parseint(self.getnumbertext())
                };

                handler(gamecreatedata);
            });
        },

        reportsuccess: function (message) {
            var successmessage = $("<p class='success-message' style='color:green'>" + message + "</p>");
            this.rootelement.append(successmessage);
            successmessage.fadeout(2000, function () {
                successmessage.remove();
            });
        },

        reporterror: function (errormessage) {
            this.rootelement.append("<p class='error-message' style='color:red'>" + errormessage + "</p>");
        },

        clearerrorreport: function () {
            var errormessages = this.rootelement.children(".error-message");
            errormessages.fadeout(200, function () {
                errormessages.remove();
            });
        }
    });

    var makeguesscontrol = class.create({
        build: function (selector) {
            
            var self = this;
            self.rootelement = $(selector);

            return buildcontrolpromise("../make-guess-control.html", this.rootelement).then(function (newrootelement) {
                self.rootelement = newrootelement;
            });
        },

        getnumbertext: function () {
            return $("#guess-number-input").val();
        },

        attachguessclickhandler: function (handler, removeprevioushandlers) {

            var self = this;

            if (removeprevioushandlers) {
                $(this.rootelement).off("click");
            }

            $(this.rootelement).on("click", "#make-guess-button", function () {
                var makeguessdata = {
                    number: parseint(self.getnumbertext())
                };

                handler(makeguessdata);
            });
        },

        show: function(){
            this.rootelement.show();
        },

        hide: function () {
            this.rootelement.hide();
        },

        reporterror: function (errormessage) {
            this.rootelement.append("<p class='error-message' style='color:red'>" + errormessage + "</p>");
        },

        clearerrorreport: function () {
            this.rootelement.children(".error-message").remove();
        }
    });

    var joingamecontrol = class.create({
        buildaftercontent: function (listitem) {
            var container = $("<div class='control-container'></div>");
            this.rootelement = container;
            $(listitem).append(container);

            return httprequester.getjson("../join-game-control.html").then(function (joinhtml) {
                container.append(joinhtml);
            });
        },

        getroot: function(){
            return this.rootelement;
        },

        deletefromdom: function () {
            $("#game-login-container").parent().remove();
        },

        getpasswordtext: function () {
            return $("#game-login-password-input").val();
        },

        getnumbertext: function () {
            return $("#game-login-number-input").val();
        },

        attachjoinclickhandler: function (handler, removeprevioushandlers) {

            var self = this;

            if (removeprevioushandlers) {
                $(this.rootelement).off("click");
            }

            $(this.rootelement).on("click", "#game-login-button", function () {
                var gamelogindata = {
                    password: self.getpasswordtext(),
                    number: parseint(self.getnumbertext())
                };

                handler(gamelogindata);
                return false;
            });
        },

        reporterror: function (errormessage) {
            this.rootelement.append("<p class='error-message' style='color:red'>" + errormessage + "</p>");
        },

        clearerrorreport: function () {
            this.rootelement.children(".error-message").remove();
        }
    });

    var gridviewcontrol = class.create({
        build: function (selector, mainheader, headers, datamatrix) {
            var container = $("<div class='control-container'></div>");
            $(selector).append(container);
            this.rootelement = container;

            this.mainheader = mainheader;
            this.headers = headers;

            this.changedata(datamatrix);
        },

        changedata: function (data) {
            var resulthtml = "<h2>" + this.mainheader + "</h2><table>";

            resulthtml += "<thead>";
            resulthtml += "<tr>";
            for (var i in this.headers) {
                resulthtml += "<th>" + this.headers[i] + "</th>";
            }
            resulthtml += "</tr>";
            resulthtml += "</thead>";

            resulthtml += "<tbody>";
            for (var row in data) {
                var currrow = data[row];
                resulthtml += "<tr>";
                for (var col in currrow) {
                    resulthtml += "<td>" + currrow[col] + "</td>";
                }
                resulthtml += "</tr>";
            }
            resulthtml += "</tbody>";
            resulthtml += "</table>";

            this.rootelement.html(resulthtml);
        }
    });

    return {
        LoginControl: LoginControl,
        RegisterControl: RegisterControl,
        ListControl: ListControl,
        JoinGameControl: JoinGameControl,
        GuessControl: MakeGuessControl,
        CreateGameControl: CreateGameControl,
        GridViewControl: GridViewControl
    }
}())