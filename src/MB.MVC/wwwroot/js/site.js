document.addEventListener("DOMContentLoaded", function () {
    var vh = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);
    document.addEventListener("wheel", function (event) {
        if (event.deltaY > 0) {
            window.scrollBy(0, vh);
        }
        else {
            window.scrollBy(0, -vh);
        }
    });
}, false);
//# sourceMappingURL=site.js.map