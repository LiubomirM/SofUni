function createParagraph(id, text) {

        var newElement = document.createElement('p');
        var newText = document.createTextNode(text);
        newElement.appendChild(newText);
        document.getElementById(id).appendChild(newElement);
}