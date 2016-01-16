var turn = 0;
var hasWon = false;
var winTeam;
var color = "#7fff00";

function cellClick(id) {
    var cell = document.getElementById(id);

    if (hasWon) {
        return;
    }

    if (cell.innerHTML == "✖" || cell.innerHTML == "O") {
        return;
    }

    if (turn % 2 == 0) {
        cell.innerHTML = "✖";
        turn++;
    }
    else {
        cell.innerHTML = "O";
        turn++;
    }

    hasWon = checkSequence();

    if (hasWon) {
        log.innerHTML = winTeam + " wins!";
    } else if (turn == 9) {
        writeOnLog("Nobody wins!");
    }
}

function checkSequence() {
    var center = getElement(4);
    var topLeft = getElement(0);
    var bottomRight = getElement(8);

    var checkCenter = center == "✖" || center == "O";
    var firstDiagonal = center == getElement(0) && center == getElement(8);
    var secondDiagonal = center == getElement(2) && center == getElement(6);
    var vertical = center == getElement(1) && center == getElement(7);
    var horizontal = center == getElement(3) && center == getElement(5);
    var centerSequence = firstDiagonal || secondDiagonal || vertical || horizontal;

    if (checkCenter && centerSequence) {
        winTeam = center;
        if (firstDiagonal) {
            document.getElementById(0).style.color = color;
            document.getElementById(4).style.color = color;
            document.getElementById(8).style.color = color;
        }
        else if (secondDiagonal){
            document.getElementById(2).style.color = color;
            document.getElementById(4).style.color = color;
            document.getElementById(6).style.color = color;
        }
        else if (vertical){
            document.getElementById(1).style.color = color;
            document.getElementById(4).style.color = color;
            document.getElementById(7).style.color = color;
        } else {
            document.getElementById(3).style.color = color;
            document.getElementById(4).style.color = color;
            document.getElementById(5).style.color = color;
        }
        return true;
    }

    var checkTopLeft = topLeft == "✖" || topLeft == "O";
    horizontal = topLeft == getElement(1) && topLeft == getElement(2);
    vertical = topLeft == getElement(3) && topLeft == getElement(6);
    var topLeftSequence = horizontal || vertical;

    if (checkTopLeft && topLeftSequence) {
        winTeam = topLeft;
        if (horizontal) {
            document.getElementById(0).style.color = color;
            document.getElementById(1).style.color = color;
            document.getElementById(2).style.color = color;
        } else {
            document.getElementById(0).style.color = color;
            document.getElementById(3).style.color = color;
            document.getElementById(6).style.color = color;
        }
        return true;
    }

    var checkBottomRight = bottomRight == "✖" || bottomRight == "O";
    vertical = bottomRight == getElement(2) && bottomRight == getElement(5);
    horizontal = bottomRight == getElement(6) && bottomRight == getElement(7);
    var bottomRightSequence = horizontal || vertical;

    if (checkBottomRight && bottomRightSequence) {
        winTeam = bottomRight;
        if (horizontal) {
            document.getElementById(6).style.color = color;
            document.getElementById(7).style.color = color;
            document.getElementById(8).style.color = color;
        } else {
            document.getElementById(2).style.color = color;
            document.getElementById(5).style.color = color;
            document.getElementById(8).style.color = color;
        }
        return true;
    }

    return false;
}

function getElement(id) {
    var element = document.getElementById(id).innerHTML;
    return element;
}