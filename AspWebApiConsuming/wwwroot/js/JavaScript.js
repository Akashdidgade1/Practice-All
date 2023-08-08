
    $(document).ready(function () {
        alert("test");

        $(#btnAll).click(function () {
            alert("test alert");
            $.ajax({
                type: "GET",
                url: "https://localhost:7132/api/Friends/",
                dataType: "json",
                success: function (data) {
                    $(#friends).empty();
                    $(#FriendsDetails).empty();
                    $.each(data, function (i, val) {
                        $(#friends).append("<li>" + val.id + "</li>");
                    });
                }
            })
        });
    });