document.addEventListener("DOMContentLoaded", () => {
    const viewHeight = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);

    document.addEventListener("wheel", (event: WheelEvent) => {
        if (event.deltaY > 0) {
            window.scrollBy(0, viewHeight);
        } else {
            window.scrollBy(0, -viewHeight);
        }
    });

    

}, false);

const darkMode = () => {
    var element = document.body;

    element.classList.toggle("dark-mode");
};