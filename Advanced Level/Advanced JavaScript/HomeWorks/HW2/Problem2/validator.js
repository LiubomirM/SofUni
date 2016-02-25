function check() {
    var text = document.getElementsByTagName('input')[0].value;
    document.getElementById('isValid').innerHTML = text;
    document.getElementById('isValid').style.width = '173px';
    if(text.match(/\w+@\w+\.\w{2,}/g)) {
        document.getElementById('isValid').style.backgroundColor = '#90ee90';
    }
    else {
        document.getElementById('isValid').style.backgroundColor = '#ff0000';
    }
}