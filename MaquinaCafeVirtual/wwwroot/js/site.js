function BuscarValorBebida() {

    var select = document.getElementById("ProdutoId");
    var value = select.options[select.selectedIndex].value;
    var URL = "home/BuscarValor";

    if (value > 0) {
        $.ajax({
            url: URL,
            dataType: "json",
            type: "GET",
            cache: false,
            data: { produtoId: value },
            success: function (data) {
                if (data.success) {
                    var valor = String(data.valor);
                    if (valor.length > 2) {
                        $("#valorBebida").text("Valor: R$ " + valor.substring(0, valor.length - 2) + "," + valor.substring(valor.length - 2));
                        ValidarBotao();
                    }
                    else {
                        $("#valorBebida").text("Valor: R$ 0," + valor);
                        ValidarBotao();
                    }
                }
                else {
                    alert(data.message);
                    $("#valorBebida").text("");
                    ValidarBotao();
                }
            }
        });
    }
    else {
        $("#valorBebida").text("");
        ValidarBotao();
    }
}

function InserirMoeda(valor) {

    if (valor === 1 || valor === 5) {
        msgErro
        $("#msgErro").text("Erro ao receber a moeda, por favor tente novamente!");
        $("#msgSucesso").text("");
    }
    else {
        $("#msgErro").text("");
        var valorAntigo = $("#valorMoedas").val().replace("Valor: R$ 0,", "").replace("Valor: R$ ", "").replace(",", "");
        var valorNovo = valorAntigo.length > 0 ? (parseInt(valor) + parseInt(valorAntigo)) : valor;
        var valorString = String(valorNovo);

        if (valorString.length > 2) {
            $("#valorMoedas").val("Valor: R$ " + valorString.substring(0, valorString.length - 2) + "," + String(valorString).substring(valorString.length - 2));
        }
        else
            $("#valorMoedas").val("Valor: R$ 0," + valorString);
    }

    ValidarBotao();
}

function Comprar() {
    var select = document.getElementById("ProdutoId");
    var produto = select.options[select.selectedIndex].value;
    var valorMoedas = $("#valorMoedas").val().replace("Valor: R$ 0,", "").replace("Valor: R$ ", "").replace(",", "");
    var valorBebida = $("#valorBebida").text().replace("Valor: R$ 0,", "").replace("Valor: R$ ", "").replace(",", "");
    var trocoDevolver = parseInt(valorMoedas) - parseInt(valorBebida);

    var URL = "home/Comprar";

    $.ajax({
        url: URL,
        dataType: "json",
        type: "POST",
        cache: false,
        data: { produtoId: produto, valorPago: valorMoedas, troco: trocoDevolver },
        success: function (data) {
            if (data.success) {

                if (data.trocoDevolver > 0) {
                    var troco = String(data.trocoDevolver);
                    if (troco.length > 2) {
                        $("#msgSucesso").text(data.message + " Seu troco é de: R$ " + troco.substring(0, troco.length - 2) + "," + troco.substring(troco.length - 2));
                        $("#msgErro").text("");
                        $("#valorBebida").text("");
                        $("#valorMoedas").val("");
                        document.getElementById("ProdutoId").value = 0;
                        ValidarBotao();
                    }
                    else {
                        $("#msgSucesso").text(data.message + " Seu troco é de: R$ 0," + troco);
                        $("#msgErro").text("");
                        $("#valorBebida").text("");
                        $("#valorMoedas").val("");
                        document.getElementById("ProdutoId").value = 0;
                        ValidarBotao();
                    }
                }
                else {
                    $("#msgSucesso").val(data.message);
                    $("#msgErro").text("");
                    $("#valorBebida").text("");
                    $("#valorMoedas").val("");
                    document.getElementById("ProdutoId").value = 0;
                    ValidarBotao();
                }
            }
            else {
                $("#msgErro").text(data.message);
                $("#msgSucesso").text("");
            }
        }
    });
}

function ValidarBotao() {

    var valorMoedas = $("#valorMoedas").val().replace("Valor: R$ 0,", "").replace("Valor: R$ ", "").replace(",", "");
    var valorBebida = $("#valorBebida").text().replace("Valor: R$ 0,", "").replace("Valor: R$ ", "").replace(",", "");

    if (valorBebida != "" && valorBebida > 0 && parseInt(valorMoedas) >= parseInt(valorBebida)) {
        $("#btnComprar").removeClass("btn-secondary");
        $("#btnComprar").addClass("btn-primary");
        $("#btnComprar").prop("disabled", false);
    }
    else {
        $("#btnComprar").addClass("btn-secondary");
        $("#btnComprar").removeClass("btn-primary");
        $("#btnComprar").prop("disabled", true);
    }
}
