var HTMLGen = {

    createParagraph : function createParagraph(id, text){
        document.getElementById(id).innerHTML += '<p>' + text + '</p>';
    },

    createDiv : function createDiv(id, className) {
        document.getElementById(id).innerHTML += '<div class =' + className + '></div>';
    },
    createLink : function createLink(id, text, url) {
        document.getElementById(id).innerHTML += '<a href=' + url + '>' + text + '</a>'
    }
};

HTMLGen.createParagraph('wrapper', 'Soft Uni');
HTMLGen.createDiv('wrapper', 'section');
HTMLGen.createLink('book', 'C# basics book', 'http://www.introprogramming.info/');

