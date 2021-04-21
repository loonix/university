loadFile('sidebar', 'ui/layout/sidebar.html');

function loadFile(id, file) {
    document.getElementById(id).innerHTML = '<object type="text/html" data="' + file + '"></object>';
}