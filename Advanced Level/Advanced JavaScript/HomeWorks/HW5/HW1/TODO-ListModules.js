var ToDoList = (function () {
    var Container = (function () {
        function Container(title) {
            this._title = title;
        }

        Container.prototype.addToDOM = function (parent) {
            var container, title, newSection, newSectionButton, newSectionTitle;

            container = document.createElement('div');
            container.id = 'container';
            title = document.createElement('h1');
            title.innerHTML = this._title;
            container.appendChild(title);
            newSectionTitle = document.createElement('input');
            newSectionTitle.placeholder = 'Title...';
            newSectionButton = document.createElement('input');
            newSectionButton.type = 'button';
            newSectionButton.value = 'New Section';
            newSectionButton.addEventListener("click", function () {
                var section = new ToDoList.Section(newSectionTitle.value);
                section.addToDOM(document.getElementById('container'));
            });
            newSection = document.createElement('div');
            newSection.id = 'newSection';
            newSection.appendChild(newSectionTitle);
            newSection.appendChild(newSectionButton);
            container.appendChild(newSection);
            if (!(document.getElementById('container'))) {
                parent.appendChild(container);
            }
        };

        return Container;
    })();

    var Section = (function () {
        var sectionsCreated = 0;

        function Section(title) {
            if (title === '') {
                throw Error('The section title cannot be empty');
            }
            this._title = title;
            sectionsCreated++;
        }

        Section.prototype.addToDOM = function (parent) {
            var section, title, newItemContent, newItemButton, newItem, lastSectionID;

            section = document.createElement('div');
            lastSectionID = document.getElementById('container').lastChild.previousSibling.id;
            section.id = 'section_' + Number(sectionsCreated);

            title = document.createElement('h2');
            title.innerHTML = this._title;
            section.appendChild(title);
            newItemContent = document.createElement('input');
            newItemContent.placeholder = 'Add item...';
            newItemButton = document.createElement('input');
            newItemButton.type = 'button';
            newItemButton.value = '+';
            newItemButton.addEventListener("click", function () {
                var item = new ToDoList.Item(newItemContent.value);
                item.addToDOM(document.getElementById(section.id));
            });
            newItem = document.createElement('div');
            newItem.id = 'newSection';
            newItem.appendChild(newItemContent);
            newItem.appendChild(newItemButton);
            section.appendChild(newItem);

            if (!(document.getElementById(section.id))) {
                parent.insertBefore(section, parent.lastChild);
            }
        };

        return Section;
    })();

    var Item = (function () {

        function Item(content) {
            if (content === '') {
                throw Error('The item content cannot be empty');
            }
            this._content = content;
        }

        Item.prototype.addToDOM = function (parent) {
            var item, lastItem, checkbox, self, content, itemDiv;

            function isCompleted() {
                var itemContent;
                itemContent=document.getElementById('item' + this._id).lastChild.firstChild;
                if (document.getElementById(this._id).checked) {
                    itemContent.style.backgroundColor = 'lightgreen';
                }
                else {
                    itemContent.style.backgroundColor = 'white';
                }
            }

            item = document.createElement('div');
            lastItem = parent.lastChild.previousSibling;
            if (lastItem != undefined) {
                if (lastItem.id != '') {
                    this._id = parent.id[parent.id.length - 1] +
                        (Number(lastItem.id[lastItem.id.length - 1]) + 1);
                    item.id = 'item' + this._id;
                }
                else {
                    this._id = parent.id[parent.id.length - 1] + 1;
                    item.id = 'item' + parent.id[parent.id.length - 1] + 1;
                }
                checkbox = document.createElement('input');
                checkbox.type = 'checkbox';
                checkbox.id = this._id;
                self = this;
                checkbox.addEventListener("click", function () {
                    isCompleted.call(self)
                });
                content = document.createElement('p');
                itemDiv = document.createElement('div');
                itemDiv.appendChild(content);
                itemDiv.appendChild(document.createElement('hr'));
                content.innerHTML = this._content;
                item.appendChild(checkbox);
                item.appendChild(itemDiv);
                if (!(document.getElementById(item.id))) {
                    parent.insertBefore(item, parent.lastChild);
                }
            }
        };

        return Item;
    })();

    return {
        Container: Container,
        Section: Section,
        Item: Item
    }
})
();

var list = new ToDoList.Container('TODO List');
list.addToDOM(document.body);