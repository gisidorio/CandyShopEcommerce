var numero_atual_pagina = 1;

$(function () {
    var qtd_registros_exibidos_pagina = 10;
    amountButtonsPage(keywords.length, qtd_registros_exibidos_pagina);
    update(qtd_registros_exibidos_pagina, numero_atual_pagina);
    //updateProductWithoutStock(qtd_registros_exibidos_pagina, numero_atual_pagina);
});

$('#btnSearch').on('click', function (e) {
    e.preventDefault();

    var CompanyObj = {
        EIN: $('#ein').val(),
        CityName: $('#CityName').val()
    };

    DynamicSearch(CompanyObj);
});

var keywords = @Html.Raw(Json.Encode(ViewBag.Keywords));
@*var products_not_stock = @Html.Raw(Json.Encode(ViewBag.ProductsNotStock));
var product_obj = {};
var product_element_delete;
let stock_element;*@



/* AO CLICAR NO NÚMERO DA PÁGINA, ELE RESGATA O NÚMERO DA PÁGINA
   E O ATRIBUI A UMA VARIÁVEL
   OBS: o 'on' TEM UM 'a.pagina' que é um tratamento para a inserção dinâmica de classe
   porque o 'a.pagina' é inserido via javascript */
$('.pagination').on('click', 'a.pagina', function (e) {
    e.preventDefault();
    qtd_registros_exibidos_pagina = $('#qtdRegistrosExibidos').children('option:selected').text();
    numero_atual_pagina = $(this).html();
    update(qtd_registros_exibidos_pagina, numero_atual_pagina);
});

$('.pagination').on('click', 'li.next', function (e) {
    e.preventDefault();
    qtd_registros_exibidos_pagina = $('#qtdRegistrosExibidos').children('option:selected').text();
    var qtd_botoes_criados = amountButtonsPage(keywords.length, qtd_registros_exibidos_pagina);
    numero_atual_pagina = parseInt(numero_atual_pagina) + 1;
    if (numero_atual_pagina > qtd_botoes_criados)
        numero_atual_pagina = qtd_botoes_criados;
    numero_atual_pagina = numero_atual_pagina > qtd_botoes_criados ? numero_atual_pagina = qtd_botoes_criados : numero_atual_pagina;
    update(qtd_registros_exibidos_pagina, numero_atual_pagina);
});

$('.pagination').on('click', 'li.previous', function (e) {
    e.preventDefault();
    qtd_registros_exibidos_pagina = $('#qtdRegistrosExibidos').children('option:selected').text();
    numero_atual_pagina -= 1;
    numero_atual_pagina = numero_atual_pagina <= 0 ? 1 : numero_atual_pagina;
    update(qtd_registros_exibidos_pagina, numero_atual_pagina);
});


/* AO CLICAR NO NO COMBO (SELECT), ELE RESGATA A QUANTIDADE
   DE REGISTROS QUE SERÃO EXIBIDOS POR PÁGINA */
//aqui também ocorrerá a exibição de mais de 10 páginas
$('#qtdRegistrosExibidos').on('change', function (e) {
    var qtd_registros_exibidos = $(this).children('option:selected').text();

    if (numero_atual_pagina > amountButtonsPage(keywords.length, qtd_registros_exibidos))
        numero_atual_pagina = amountButtonsPage(keywords.length, qtd_registros_exibidos);
    else
        amountButtonsPage(keywords.length, qtd_registros_exibidos)

    update(qtd_registros_exibidos, numero_atual_pagina);
});

/* EVENTO DO BOTÃO QUE ESTÁ NO MODAL ADICIONAR  */
$('#btnAdicionar').on('click', function (e) {
    e.preventDefault();

    var quantidade_paginas = $('.pagina').length;
    qtd_registros_exibidos_pagina = $('#qtdRegistrosExibidos').children('option:selected').text();


    var cliente = {
        nome: $('#txtNome').val(),
        sobrenome: $('#txtSobrenome').val(),
        idade: $('#txtIdade').val(),
        ativo: $('#txtAtivo').val()
    };

    keywords.push(cliente);
    update(qtd_registros_exibidos_pagina, quantidade_paginas);
});

$('#tblBodyKeywords').on('click', 'button#btnIdLink', function (e) {
    e.preventDefault();
    let product_id = $(this).html();
    stock_element = $(this).parent().children().eq(2);
    $('#txtProductId').val(product_id);
});

$('#tblBodyKeywords').on('click', 'button.btnLinkDelete', function (e) {
    e.preventDefault();

    var register_id = $(this).parent().find(':first-child').html();

    product_obj.CompanyId = $('#companyId').val();
    product_obj.ProductId = register_id;
    product_element_delete = $(this).parent();
});

$('#btnDelete').click(function (e) {
    e.preventDefault();

    product_obj = JSON.stringify({ 'Product': product_obj });

    $.ajax({
        url: "@Url.Action("DeleteProduct", "Companies")",
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        type: 'POST',
        data: product_obj,
        success: function (results) {
            product_element_delete.remove();
        },
        failure: function (response) {
        }
    });
});

$('#btnNovo').on('click', function (e) {
    e.preventDefault();

    $('#txtNome').val('');
    $('#txtSobrenome').val('');
    $('#txtIdade').val('');
    $('#txtAtivo').val('');

    $('#txtNome').focus();
});


/* ATUALIZA A TABELA */
function update(qtd_registros_exibidos_pagina, nro_atual_pagina) {

    var calculo = qtd_registros_exibidos_pagina * nro_atual_pagina;
    var condicao_parada = calculo - qtd_registros_exibidos_pagina;
    var i = calculo - 1;

    $('#tblBodyKeywords').empty();
    while (i >= condicao_parada) {
        if (calculo > keywords.length) {
            for (var indice = condicao_parada; indice < keywords.length; indice++) {
                var nova_linha = createRegister(indice);
                $('#tblBodyKeywords').append(nova_linha);
            }
            break;
        }

        var nova_linha = createRegister(i);
        $('#tblBodyKeywords').prepend(nova_linha);
        i--;
    }
}

/* CRIA A NOVA LINHA/REGISTRO NA TABELA QUEM TEM A PAGINAÇÃO E RETORNA A NOVA LINHA */
function createRegister(indice) {
    var nova_linha = $('<tr></tr>');
    nova_linha = nova_linha.append('<button class=\"btnLink\" data-toggle="modal" id="btnIdLink" data-target="#ProductUpdateModal">' + keywords[indice].KeywordId +
        '</button>');
    nova_linha = nova_linha.append('<td>' + keywords[indice].Word + '</td>');
    nova_linha = nova_linha.append('<td>' + ToJavaScriptDate(keywords[indice].RegisterDate) + '</td>');
    nova_linha = nova_linha.append('<button class=\"btnLinkDelete\" data-toggle="modal" data-target="#ProductDeleteModal">' + "Delete" +
        '</button>');
    return nova_linha;
}

/* CRIA A QUANTIDADE DE BOTÕES DE PÁGINA PROPORCIONALMENTE A QUANTIDADE DE REGISTROS
   QUE SERÃO EXIBIDOS NA PÁGINA */
function amountButtonsPage(qtd_total_registros, qtd_registros_exibidos_pagina) {

    var indice_botao = 1;
    qtd_botoes = qtd_total_registros / qtd_registros_exibidos_pagina;

    $('.pagina').remove(); // remove todos os botões
    while (indice_botao <= qtd_botoes) {
        var item_lista = $('<li class="page-item"></li>');
        var link_pagina = $('<a class="page-link">' + indice_botao + '</a></li>').addClass('pagina');
        item_lista.append(link_pagina);
        item_lista.insertBefore('.next');
        indice_botao++;
    }

    if (qtd_total_registros % qtd_registros_exibidos_pagina != 0) {
        var item_lista = $('<li class="page-item"></li>');
        var link_pagina = $('<a class="page-link">' + indice_botao + '</a></li>').addClass('pagina');
        item_lista.append(link_pagina);
        item_lista.insertBefore('.next');
    }

    return indice_botao;
}

/* CONVERTE UMA DATA EM FORMATO JSON PARA DATA EM FORMATO JS */
function ToJavaScriptDate(value) {
    var pattern = /Date\(([^)]+)\)/;
    var results = pattern.exec(value);
    var dt = new Date(parseFloat(results[1]));
    return (dt.getMonth() + 1) + "/" + dt.getDate() + "/" + dt.getFullYear();
}