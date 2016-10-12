function TabsHover(t) {
    t.setAttribute('class', 'active');   
}

function TabsOut(t) {
    $(t).removeClass('active');
}

function CheckPic() {
    // alert($("#Movies_Name").text());
    console.log($("#Movies_PicUrl")[0].value);
    var imgUrl = $("#Movies_PicUrl")[0].value
    $("#imgView")[0].src = imgUrl;
}
