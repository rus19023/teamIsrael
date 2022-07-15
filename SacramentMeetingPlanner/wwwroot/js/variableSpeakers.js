var numberSelector = document.querySelector("#numParticipants");
numberSelector.addEventListener("change", getNumber);

function getNumber() {
    showDivs(parseFloat(this.value));
}

//function addInputBoxes(number) {
//    //clears out previous input boxes
//    var variableDivs = document.querySelectorAll(".variable");
//    if (variableDivs != null) {
//        variableDivs.forEach(div => div.remove());
//    }
    
//    //creates required number of new input boxes
//    //starts at highest number and goes to lowest to keep input boxes in ascending order
//    for (let i = number; i > 0; i--) {
//        var div = document.createElement("div");
//        div.setAttribute("class", "form-group variable");
        
//        var label = document.createElement("label");
//        label.setAttribute("asp-for", "participant");
//        label.setAttribute("class", "control-label");
//        label.textContent = "Participant " + i;

//        var select = document.createElement("select");
//        selectList.forEach(item => {
//            var option = document.createAttribute("option");
//            option.setAttribute("value", item.ID);
//            option.textContent = item.FullName;
//            alert(option);

//            select.appendChild(option);
//        });

//        var span = document.createElement("span");
//        span.setAttribute("asp-validation-for", "participant");
//        span.setAttribute("class", "text-danger");

//        //adds div and all needed child elements to DOM
//        div.appendChild(label);
//        div.appendChild(select);
//        div.appendChild(span);

//        //appends div directly after div containing number selector
//        var participantsDiv = document.querySelector("#participantsDiv");
//        participantsDiv.after(div);
//    }
//}

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



