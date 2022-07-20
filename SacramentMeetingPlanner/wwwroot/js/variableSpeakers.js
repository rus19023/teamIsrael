var numberSelector = document.querySelector("#numParticipants");
showDivs(numberSelector.options[numberSelector.selectedIndex].text);
numberSelector.addEventListener("change", getNumber);

function getNumber() {
    showDivs(parseFloat(this.value));
}

function showDivs(number) {
    var speakerDropdowns = document.querySelectorAll(".speakers");
    var i = 0;
    speakerDropdowns.forEach(dropdown => {
        if (i < number) {
            dropdown.classList.remove("hidden");
        } else {
            dropdown.classList.add("hidden");
        }
        i++;
    });
}



