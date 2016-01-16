function replaceATag(str) {
    var re = /<a([\w\W]*)>([\w\W]*)<\/a>/gi;

    var replaced = str.replace(re, '[URL $1]$2[/URL]');

    console.log(replaced);
}

replaceATag('<ul> <li> <a href=http://softuni.bg>SoftUni</a> </li> </ul>');