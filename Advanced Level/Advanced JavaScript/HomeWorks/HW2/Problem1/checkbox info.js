function showMe (checkbox) {
    if (checkbox.checked) {
        document.getElementById('details').style.visibility = "visible";
    }
    else {
        document.getElementById('details').style.visibility = "hidden";
    }
}
