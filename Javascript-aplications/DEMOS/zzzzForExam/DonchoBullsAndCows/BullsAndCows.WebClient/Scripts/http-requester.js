/// <reference path="jquery-2.0.2.js" />
var httpRequester = (function () {
	function getJSON(url, success, error) {
		$.ajax({
			url: url,
			type: "GET",
			timeout: 100000,
			contentType: "application/json",
			success: success,
			error: error
		});
	}
	function postJSON(url, data, success, error) {
	    /// <reference path="jquery-2.0.2.js" />
	    var httpRequester = (function () {
	        function getJSON(url, success, error) {
	            $.ajax({
	                url: url,
	                type: "GET",
	                timeout: 100000,
	                contentType: "application/json",
	                success: success,
	                error: error
	            });
	        }
	        function postJSON(url, data, success, error) {
	            $.ajax({
	                url: url,
	                type: "POST",
	                contentType: "application/json",
	                timeout: 100000,
	                data: JSON.stringify(data),
	                success: success,
	                error: error
	            });
	        }
	        return {
	            getJSON: getJSON,
	            postJSON: postJSON
	        };
	    }()); $.ajax({
			url: url,
			type: "POST",
			contentType: "application/json",
			timeout: 100000,
			data: JSON.stringify(data),
			success: success,
			error: error
		});
	}
	return {
		getJSON: getJSON,
		postJSON: postJSON
	};
}());