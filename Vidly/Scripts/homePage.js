
$(document).ready(function () {
    var locationElement;

    //dispaly the table and navagate to this pareent's div
    $(".upload-info").click(function () {
        locationElement = this.parentNode;
        console.log(locationElement);
    });

    //chooising movie to be uploaded
    $(".chooseable").click(function () {
        //change img and the title...
        var url
        url = this.getAttribute("value-url");
        locationElement.getElementsByTagName("img")[0].src = url;
        locationElement.getElementsByTagName("h4")[0].innerText = this.innerText;
    });

   
 

});

