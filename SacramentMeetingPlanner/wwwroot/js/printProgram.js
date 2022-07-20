var button = document.querySelector('#printPDF');
button.addEventListener('click', rearrangeLayout);

function rearrangeLayout() {
    var program = document.querySelector("#programContainer");
    program.classList.add("programGrid");
    program.classList.remove("bg-amber-50");

    var heading = document.querySelector("#headingContainer");
    heading.classList.add("programHeading");

    var actions = document.querySelector("#meetingActions");
    actions.classList.add("noDisplay");

    var content = document.querySelector("#meetingContent");
    content.classList.add("programContent");

    var rows = document.querySelectorAll(".programRow");
    rows.forEach(row => {
        row.classList.add("formattedRow");
        row.classList.remove("bg-amber-100");
        row.classList.remove("bg-amber-50");
        row.classList.remove("even:bg-amber-100");
        row.classList.remove("odd:bg-amber-50");
    });

    var topicDivs = document.querySelectorAll(".topic");
    topicDivs.forEach(topic => {
        topic.classList.remove("sm:grid");
        topic.classList.add("noDisplay");
    });

    print();
}

async function print() {
    var date = document.querySelector("#date").innerHTML;
    var filename = "Program - " + date;

    var element = document.querySelector('#programContainer');
    var opt = {
        filename: filename,
        jsPDF: {
            format: "letter",
            orientation: "landscape"
        }

    };
    html2pdf(element, opt).then(resetFormat);
}

function resetFormat() {
    var program = document.querySelector("#programContainer");
    program.classList.remove("programGrid");
    program.classList.add("bg-amber-50");

    var heading = document.querySelector("#headingContainer");
    heading.classList.remove("programHeading");

    var actions = document.querySelector("#meetingActions");
    actions.classList.remove("noDisplay");

    var content = document.querySelector("#meetingContent");
    content.classList.remove("programContent");

    var rows = document.querySelectorAll(".programRow");
    for (var i = 0; i < rows.length; i++) {
        rows[i].classList.remove("formattedRow");
        if (i % 2 === 0) {
            rows[i].classList.add("bg-amber-100");
        } else {
            rows[i].classList.remove("bg-amber-50");
        }
    }

    var topicDivs = document.querySelectorAll(".topic");
    topicDivs.forEach(topic => {
        topic.classList.add("sm:grid");
        topic.classList.remove("noDisplay");
    });
    

}