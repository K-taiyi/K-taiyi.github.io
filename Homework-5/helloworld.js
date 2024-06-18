var http = require("http");

http.createServer(function(req,res){
    res.setHeader('Access-control-Allow-Origin','*');
    res.write("Hello world");
    res.end();
}).listen(2000);