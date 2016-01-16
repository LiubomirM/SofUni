var button = document.getElementsByTagName("button")[0];
button.addEventListener("click",calculateArea, false);

function calculateArea() {
    var radius = document.getElementsByTagName("input")[0].value;
    var area = Math.PI * radius * radius;
    document.getElementById("result").innerHTML += "<p>r = " + radius + "; area = " + area;
}