
/*DOM Functions*/

const hidePortrait = function () {
    let characterPortraits = document.querySelectorAll(".character-portrait");
    console.dir(characterPortraits);

    characterPortraits.forEach((p) => {
        p.addEventListener("click", (e) => {
            console.log(p);
        });
    });
}


/*Events*/
document.addEventListener("DOMContentLoaded", () => {
    hidePortrait();
});