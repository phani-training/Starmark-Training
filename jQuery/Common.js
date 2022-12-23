function get(id){
    return document.getElementById(id).value;
}

function setText(id, value){
    document.getElementById(id).value = value
}

function setHtml(id, content){
    document.getElementById(id).innerHTML = content
}