const appUrl = 'https://localhost:44358/api/';
let currentUser = null;

function renderMessages(){
	
}

function loadMessages{
    $.get({
        url: appUrl + 'messages/all',
	success: function success(data){
console.log(data);
    },
    error: function error(error){
console.log(error);
    }
    });
}

function createMessage{
	
}