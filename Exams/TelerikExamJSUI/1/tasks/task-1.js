function solve() {
    return function (selector, isCaseSensitive) {
        var rootElement = document.querySelector(selector);
        isCaseSensitive = isCaseSensitive || false;

        var addControlsClass = document.createElement('DIV');  //wrappera za add
        addControlsClass.setAttribute('class', 'add-controls');
        addControlsClass.style.border = '1px solid black';
        addControlsClass.innerHTML = 'Enter text';
        addControlsClass.style.display = 'block';
        addControlsClass.style.margin = '0 auto';
        addControlsClass.style.width = '400px';

        var inputAddControlsField = document.createElement('INPUT');   //inputa za addvane
        inputAddControlsField.setAttribute('type', 'text');
        inputAddControlsField.setAttribute('name', 'inputAddField');
        inputAddControlsField.setAttribute('id', 'inputAddField');
        inputAddControlsField.style.width = '120px';
        inputAddControlsField.style.display = 'inline-block';
        inputAddControlsField.style.margin = '0 auto';

        var inputAddButton = document.createElement('BUTTON');    // add butona
        inputAddButton.setAttribute('class', 'button');
        inputAddButton.setAttribute('name', 'button');
        inputAddButton.innerHTML = 'Add';
        inputAddButton.style.display = 'block';
        inputAddButton.style.marginLeft = '90px';


        var searchControlclass = document.createElement('DIV');  //wrappera za search
        searchControlclass.setAttribute('class', 'search-controls');
        searchControlclass.style.border = '1px solid black';
        searchControlclass.innerHTML = 'Search';
        searchControlclass.style.display = 'block';
        searchControlclass.style.margin = '0 auto';
        searchControlclass.style.width = '400px';

        var inputSearchControlsField = document.createElement('INPUT');  //inputa za search
        inputSearchControlsField.setAttribute('type', 'text');
        inputSearchControlsField.setAttribute('name', 'inputSearchField');
        inputSearchControlsField.setAttribute('id', 'inputSearchField');
        inputSearchControlsField.style.display = 'block';
        inputSearchControlsField.style.marginLeft = '50px';
        inputSearchControlsField.style.width = '120px';


        var resultContainer = document.createElement('DIV');  //wrappera za result
        resultContainer.setAttribute('class', 'result-controls');
        resultContainer.style.border = '1px solid black';
        resultContainer.style.display = 'block';
        resultContainer.style.margin = '0 auto';
        resultContainer.style.width = '400px';

        var itemsList = document.createElement('DIV');
        itemsList.setAttribute('class', 'items-list');
        itemsList.setAttribute('id', 'itemsList');


        resultContainer.appendChild(itemsList);
        searchControlclass.appendChild(inputSearchControlsField);

        addControlsClass.appendChild(inputAddControlsField);
        addControlsClass.appendChild(inputAddButton);


        rootElement.appendChild(addControlsClass);
        rootElement.appendChild(searchControlclass);
        rootElement.appendChild(resultContainer);


        var listItem = document.createElement('DIV');
        listItem.setAttribute('class', 'list-item');
        listItem.style.listStyleType = 'none';
        listItem.style.display = 'block';

        var deleteButton = document.createElement('BUTTON');    // add butona
        deleteButton.setAttribute('class', 'button');
        deleteButton.setAttribute('id', 'delete');
        deleteButton.innerHTML = 'X';
        deleteButton.style.display = 'inline-block';


        //listItem.appendChild(deleteButton);
        //itemsList.appendChild(listItem);

        function addItemsToRoot() {
            var content = document.getElementById('inputAddField').value;
            var newListItem = listItem.cloneNode(true);
            var butt = deleteButton.cloneNode(true);
            newListItem.innerHTML = content;

            newListItem.appendChild(butt);

            butt.addEventListener('click', removeItemsFromRoot);
            itemsList.appendChild(newListItem);

        }

        function removeItemsFromRoot() {
            var parent = this.parentNode;
            parent.remove();
        }

        function searchItemsByPattern(pattern, isCaseSensitive) {
            var patternFromSearch = document.getElementById('inputSearchField').value;

            pattern = patternFromSearch;

            var liItemsCount = document.getElementById('itemsList').childElementCount;

            var nodes = document.getElementById('itemsList').childNodes;

            for (i = 0; i < nodes.length; i += 1) {
                var currentElement = nodes[i];
                var doChovkata = currentElement.innerHTML.indexOf('<');
                var contentOfCurrentNode = currentElement.innerHTML.substr(0, doChovkata);


                if (isCaseSensitive) {


                    var indexOfPattern = contentOfCurrentNode.indexOf(pattern);
                    if (indexOfPattern < 0) {
                        currentElement.style.display = 'none';
                    }
                    else {
                        currentElement.style.display = '';
                    }
                }

                else {
                    var patternToLower = pattern.toString().toLowerCase();
                    var indexOfPattern = contentOfCurrentNode.toLowerCase().indexOf(patternToLower);
                    if (indexOfPattern < 0) {
                        currentElement.style.display = 'none';
                    }
                    else {
                        currentElement.style.display = '';
                    }
                }
            }

        }


        inputAddButton.addEventListener('click', addItemsToRoot);
        deleteButton.addEventListener('click', removeItemsFromRoot);
        inputSearchControlsField.addEventListener('input', searchItemsByPattern);

    };
}

//module.exports = solve;