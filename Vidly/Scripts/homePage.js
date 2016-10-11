
$(document).ready(function () {
    var locationElement;

    //dispaly the table and navagate to this pareent's div
    $(".upload-info").click(function () {
        locationElement = this.parentNode;

        $(".hidden-table")[0].style.display = "block";

    });

    //chooising movie to be uploaded
    $(".chooseable").click(function () {
        //change img and the title...
        locationElement.getElementsByTagName("img")[0].src = "";

        //undispaly the tabel
        $(".hidden-table")[0].style.display = "none";
    });

    //close the table
    $("#closeTable").click(function () {
        $(".hidden-table")[0].style.display = "none";
    });

    $(function () {
        $(".hidden-table").draggable();
    });

});

