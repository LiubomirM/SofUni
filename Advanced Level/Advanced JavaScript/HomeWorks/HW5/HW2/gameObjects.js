window.onload = slide;

function slide() {
    document.getElementById("mover").style.left = currPos("mover") + 1 + "px";

    if (currPos("mover") <= currPos("rightfore")) {
        setTimeout("slide()",10);
    }

    function currPos(elem) {
        return document.getElementById(elem).offsetLeft;
    }
}
