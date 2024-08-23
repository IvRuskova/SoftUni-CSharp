
function SetLimit() {
    let num = document.getElementById("limitInput").value || 50;

    window.location = "https://localhost:7156/Numbers/Limit?num=" + num;
}