var token;
window.fbAsyncInit = function () {
    FB.init({
        appId: '469972613092742',
        channelUrl: '//http://localhost:20511/channel.html',
        status: true, // check login status
        cookie: true, // enable cookies to allow the server to access the session
        xfbml: true  // parse XFBML
    });

    FB.login(function (response) {
        if (response.authResponse) {
            token = response.authResponse.accessToken;
            getProfileInfo();
            getFriends();
        } else {
            console.log('User cancelled login or did not fully authorize.');
        }
    }, { scope: 'read_friendlists,user_photos' });
};

// Load the SDK asynchronously
(function (d) {
    var js, id = 'facebook-jssdk', ref = d.getElementsByTagName('script')[0];
    if (d.getElementById(id)) { return; }
    js = d.createElement('script'); js.id = id; js.async = true;
    js.src = "//connect.facebook.net/en_US/all.js";
    ref.parentNode.insertBefore(js, ref);
}(document));


function getProfileInfo() {
    FB.api('/me', function (response) {
        var holder = $("#profile");
        var name = response.name;
        var url = "https://graph.facebook.com/" + response.id + "/picture";
        holder.append("<img src =" + url + "/>");
        holder.append("<p>" + name + "</p>");
    });
    $("#log").css("display", "none");
}

function getFriends() {
    FB.api('/me/friends?access_token=' + token, function (response) {
        var friendsHolder = $('#friends');
        for (i = 0; i < response.data.length; i++) {
            var friendPictureUrl = 'https://graph.facebook.com/' + response.data[i].id + '/picture?width=200&height=200';
            var friendName = response.data[i].name;
            friendsHolder.append("<img src =" + friendPictureUrl + " title=" + friendName + "/>");
        }
        photos();
    });
}

//function disconnect() {
//    FB.api('/me/permissions?access_token=' + token, 'DELETE', function (res) {
//        if (res === true) {
//            console.log('app deauthorized');
//            $('#disconnect').hide('slow');
//            $('#profile').hide('slow');
//            $('#friends').hide('slow');
//            $('#log').show();
//            //window.location.reload();
//        } else if (res.error) {
//            console.error(res.error.type + ': ' + res.error.message);
//        } else {
//            console.log(res);
//        }
//    });
//}


//function getStatus() {
//    FB.Event.subscribe('auth.login', function (response) {
//        if (response.status === 'connected') {
//            // the user is logged in and has authenticated your
//            // app, and response.authResponse supplies
//            // the user's ID, a valid access token, a signed
//            // request, and the time the access token 
//            // and signed request each expire
//            var uid = response.authResponse.userID;
//            var accessToken = response.authResponse.accessToken;
//        } else if (response.status === 'not_authorized') {
//            // the user is logged in to Facebook, 
//            // but has not authenticated your app
//        } else {
//            // the user isn't logged in to Facebook.
//        }
//    });
//}