function resetBackgroundColor() {
    document.body.style.background = "white";
}

function resizeCanvas() {
    var canvas = document.getElementById("canvas");

    canvas.style.width = window.innerWidth + "px";
    setTimeout(function () {
        canvas.style.height = window.innerHeight + "px";
    }, 0);
};

function registerEvent() {
    window.onresize = resizeCanvas;
    resizeCanvas();
};