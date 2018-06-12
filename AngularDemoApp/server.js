'use strict';
var http = require('http');
var port = process.env.PORT || 1337;

var app = require('express')(); 
app.get('/index', function (req, res) {
    res.sendFile(path.join(__dirname + '/index.html'));
});

http.createServer(function (req, res) {
    res.writeHead(200, { 'Content-Type': 'text/plain' });
    res.end('Hello World\n');
}).listen(port);
