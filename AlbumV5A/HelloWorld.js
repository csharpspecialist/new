var http = require('http')
host = '127.0.0.1',
port = '9000';


var server = http.createServer(function (req, res) {
res.writeHead(200, {'Content-Type'  :  'text/html' });
res.end('<h2>Hello Party People </h2> ');



}).listen(port, host, function()
{console.log('Server running on http://' + host + ':' + port); })
