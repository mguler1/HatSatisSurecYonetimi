$(document).on('touchstart click', '#btnKaydet', function (e) {
    e.preventDefault();
    if (!$('#frmKayit').valid()) {
        swalInit.fire({
            title: "Zorunlu Bilgiler",
            html: $('#frmKayit .validationError').html(),
            icon: "error",
        });
    }
    else {
        var IslemTipi = "Kayit";
        if ($('#txtADA_ID').val() != "0") {
            IslemTipi = "Guncelleme";
        }

        var str = new FormData($('#frmKayit')[0]);
        $.ajax({
            cache: false,
            global: false,
            async: true,
            type: 'POST',
            contentType: false,
            processData: false,
            mimeType: "multipart/form-data",
            data: str,
            dataType: 'json',
            url: "Kayit",
            beforeSend: function () {
                $('#btnKaydet').prop("disabled", true);
                $('#btnKaydet').empty().append('<i class="icon-spinner2 spinner mr-2"></i>İşlem Yapılıyor');
            },
            success: function (veri) {

                if (veri.Sonuc == "valid") {
                    swalInit.fire({
                        title: 'Kayıt İşlemi Başarılı!',
                        icon: "success",
                    }).then(function () {
                        if (IslemTipi == "Kayit") {
                            window.location = 'Tanim?ID=' + veri.ID + '&SIFRELIID=' + veri.SIFRELIID;
                        }
                        else {
                            $('#modalEdit').modal('hide');
                            if (oTableListe == 0) {
                                DataTable();

                            } else {
                                oTableListe.fnDraw();
                            }
                        }
                    });
                }
                else {
                    ErrorSwalAlert(veri.Sonuc);
                }
                $('#btnKaydet').prop("disabled", false);
                $('#btnKaydet').empty().append('<i class="icon-floppy-disk mr-2"></i>Kaydet');
            },
            error: function () {
                window.location = '/Giris';
            },
            complete: function () {

            }
        });
    }
});