// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $(".btn-details-condominio").click(function () {
        var id = $(this).data("value");
        $("#body-content").load("/Condominios/Details/" + id, function () {
            $("#modal-details").modal("show");
        });
    });
    $(".btn-details-familia").click(function () {
        var id = $(this).data("value");
        $("#body-content").load("/Familias/Details/" + id, function () {
            $("#modal-details").modal("show");
        });
    });
    $(".btn-details-morador").click(function () {
        var id = $(this).data("value");
        $("#body-content").load("/Moradors/Details/" + id, function () {
            $("#modal-details").modal("show");
        });
    });
});

$('#save-condomnium').on('click', function (e) {
    e.preventDefault();
    var nome = $('#condominio-nome').val();
    var bairro = $('#condominio-bairro').val();
    var token = $('input[name="__RequestVerificationToken"]', $('#form-create-familia')).val();
    console.log(token);
    $.ajax({
        url: "/Condominios/PartialViewCreate",
        method: "POST",
        contentType: 'application/x-www-form-urlencoded; charset=utf-8',
        dataType: "json",
        data: {
            Nome: nome,
            Bairro: bairro,
            __RequestVerificationToken: token
        },
        success: function (data, textStatus, jqXHR) {
            if (data.condominioID) {
                $(".alert").text("Condominio registrado com sucesso!");
                $(".alert").show();

                var list = $(".selectpicker").html();
                list += "<option value=" + data.condominioID + ">" + data.nome + "</option>";
                $(".selectpicker").html("");
                $(".selectpicker").html(list);
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(textStatus);
            console.log(jqXHR.status);
            console.log(jqXHR.statusText);
            console.log(jqXHR.responseText);
        }
    });
});
