function SetLimit(num) {
    let num = document.getElementById("limitInput").value ;
    window.location = "https://localhost:7052/NumbersToN?num=" + num;
}