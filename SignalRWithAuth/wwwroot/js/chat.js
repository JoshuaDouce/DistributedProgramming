"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + ": " + msg;
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messagesList").appendChild(li);
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
    document.getElementById("sendButtonToUser").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

function sendMessage(event, username) {
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessageToBot", username, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
};

function sendMessageToUser(event, username) {
    var message = document.getElementById("messageInputUser").value;
    connection.invoke("SendMessageToUser", username, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
}
