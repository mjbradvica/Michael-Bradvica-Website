document.addEventListener("DOMContentLoaded", function () {
    var viewHeight = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);
    document.addEventListener("wheel", function (event) {
        if (event.deltaY > 0) {
            window.scrollBy(0, viewHeight);
        }
        else {
            window.scrollBy(0, -viewHeight);
        }
    });
}, false);
var darkMode = function () {
    var element = document.body;
    element.classList.toggle("dark-mode");
};
//# sourceMappingURL=site.js.map