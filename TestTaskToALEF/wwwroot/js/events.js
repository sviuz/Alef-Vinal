var trArray = document.getElementsByClassName('list-table-tr');

for (var i = 0; i < trArray.length; i++) {
    var tr = trArray[i];
    tr.onclick = function () {
        let trAttr = this.attributes['data-id'].textContent;
        alert(`ID: ${trAttr}`);
    }
}