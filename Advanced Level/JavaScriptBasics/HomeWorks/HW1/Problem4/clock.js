setInterval (function(){
var time = new Date();
var hour = time.getHours();
var minutes = time.getMinutes();
var seconds = time.getSeconds();

if (hour < 10){
    hour = "0" + hour;
}
if (minutes < 10) {
    minutes = "0" + minutes;
}
if (seconds < 10){
    seconds = "0" + seconds;
}
document.getElementById("timer").innerHTML = hour + ":" + minutes + ":" + seconds;
}, 1000);