(function () {

    var encryptTextArea = $('#encryptTextArea');

    $('#form0').ajaxForm({
        beforeSerialize: function () {

        },
        success: function (d) {

        },
        complete: function (xhr) {

            var obj = jQuery.parseJSON(xhr.responseText);

            //alert(obj.Data);
            encryptTextArea.val(obj.Data);

        }
    });

    var decryptText = $('#decryptText');

    $('#form1').ajaxForm({
        beforeSerialize: function () {

        },
        success: function (d) {

        },
        complete: function (xhr) {

            var obj = jQuery.parseJSON(xhr.responseText);

            //alert(obj.Data);
            decryptText.val(obj.Data);

        }
    });






})();