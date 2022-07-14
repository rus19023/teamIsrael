var numberSelector = document.querySelector("#numParticipants");
numberSelector.addEventListener("change", getNumber);

function getNumber() {
    addInputBoxes(parseFloat(this.value));
}

function addInputBoxes(number) {
    //clears out previous input boxes
    var variableDivs = document.querySelectorAll(".variable");
    if (variableDivs != null) {
        variableDivs.forEach(div => div.remove());
    }
    
    //creates required number of new input boxes
    //starts at highest number and goes to lowest to keep input boxes in ascending order
    for (let i = number; i > 0; i--) {

        var div = document.createElement("div");
        div.setAttribute("class", "form-group variable");
        
        var label = document.createElement("label");
        label.setAttribute("asp-for", "participant");
        label.setAttribute("class", "control-label");
        label.textContent = "Participant " + i;

        var input = document.createElement("input");
        input.setAttribute("asp-for", "participant");

        var span = document.createElement("span");
        span.setAttribute("asp-validation-for", "participant");
        span.setAttribute("class", "text-danger");

        //adds div and all needed child elements to DOM
        div.appendChild(label);
        div.appendChild(input);
        div.appendChild(span);

        //appends div directly after div containing number selector
        var participantsDiv = document.querySelector("#participantsDiv");
        participantsDiv.after(div);
    }
}



