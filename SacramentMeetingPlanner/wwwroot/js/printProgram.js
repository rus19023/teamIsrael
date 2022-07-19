var button = document.querySelector('#printPDF');
button.addEventListener('click', rearrangeLayout);

function rearrangeLayout() {
    var program = document.querySelector("#programContainer");
    program.classList.add("program-grid");



    print();
}

async function print() {
    var date = document.querySelector("#date").innerHTML;
    var simpleDate = date.split(" ")[1];
    var filename = "Program - " + simpleDate;

    var element = document.querySelector('#programContainer');
    var opt = {
        filename: filename,
        jsPDF: {
            format: "letter",
            orientation: "landscape"
        }

};
    html2pdf(element, opt);

    resetFormat();
}

function resetFormat() {
    var program = document.querySelector("#programContainer");
    program.classList.remove("program-grid");
}