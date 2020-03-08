document.addEventListener("DOMContentLoaded", () => {
    const vh = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);

    document.addEventListener("wheel", (event: WheelEvent) => {
        if (event.deltaY > 0) {
            window.scrollBy(0, vh);
        } else {
            window.scrollBy(0, -vh);
        }
    });

}, false);