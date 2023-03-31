$().ready(function () {

    $("#thisMonth").change(function ()
    {
        var x = document.getElementById("FSelFront");
        var MSelFront = $("#thisMonth").val();
        let date = new Date(x.value.replace(/-+/g, '/'));

        var fechaNum = date.getDate();
        var año_name = date.getFullYear();
        var Mes = "";

        switch (MSelFront) {
            case "Enero":
                Mes = "01";
                break;
            case "Febrero":
                Mes = "02";
                break;
            case "Marzo":
                Mes = "03";
                break;
            case "Abril":
                Mes = "04";
                break;
            case "Mayo":
                Mes = "05";
                break;
            case "Junio":
                Mes = "06";
                break;
            case "Julio":
                Mes = "07";
                break;
            case "Agosto":
                Mes = "08";
                break;
            case "Septiembre":
                Mes = "09";
                break;
            case "Octubre":
                Mes = "10";
                break;
            case "Noviembre":
                Mes = "11";
                break;
            case "Diciembre":
                Mes = "12";
                break;
        }

        var newDate = año_name + "/" + Mes + "/" + fechaNum;
        Redirect(newDate);
    });

    $("#thisYear").change(function ()
    {
        let meses = ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"];

        var x = document.getElementById("FSelFront");
        var YSelFront = $("#thisYear").val();
        let date = new Date(x.value.replace(/-+/g, '/'));

        var fechaNum = date.getDate();
        var mes_name = date.getMonth();
        var Mes = "";

        switch (meses[mes_name]) {
            case "Enero":
                Mes = "01";
                break;
            case "Febrero":
                Mes = "02";
                break;
            case "Marzo":
                Mes = "03";
                break;
            case "Abril":
                Mes = "04";
                break;
            case "Mayo":
                Mes = "05";
                break;
            case "Junio":
                Mes = "06";
                break;
            case "Julio":
                Mes = "07";
                break;
            case "Agosto":
                Mes = "08";
                break;
            case "Septiembre":
                Mes = "09";
                break;
            case "Octubre":
                Mes = "10";
                break;
            case "Noviembre":
                Mes = "11";
                break;
            case "Diciembre":
                Mes = "12";
                break;
        }

        var newDate = YSelFront + "/" + Mes + "/" + fechaNum;
        Redirect(newDate);
    });

    $("#btnPrevMonth").click(function ()
    {
        var x = document.getElementById("FSelFront");
        var MSelFront = $("#thisMonth").val();
        let date = new Date(x.value.replace(/-+/g, '/'));

        var fechaNum = date.getDate();
        var año_name = date.getFullYear();
        var Mes = "";

        switch (MSelFront) {
            case "Enero":
                Mes = "12";
                break;
            case "Febrero":
                Mes = "01";
                break;
            case "Marzo":
                Mes = "02";
                break;
            case "Abril":
                Mes = "03";
                break;
            case "Mayo":
                Mes = "04";
                break;
            case "Junio":
                Mes = "05";
                break;
            case "Julio":
                Mes = "06";
                break;
            case "Agosto":
                Mes = "07";
                break;
            case "Septiembre":
                Mes = "08";
                break;
            case "Octubre":
                Mes = "09";
                break;
            case "Noviembre":
                Mes = "10";
                break;
            case "Diciembre":
                Mes = "11";
                break;
        }

        if (Mes == "12") {
            año_name = año_name - 1;
        }

        var newDate = año_name + "/" + Mes + "/" + fechaNum;
        Redirect(newDate);
    });

    $("#btnNextMonth").click(function () {
        var x = document.getElementById("FSelFront");
        var MSelFront = $("#thisMonth").val();
        let date = new Date(x.value.replace(/-+/g, '/'));

        var fechaNum = date.getDate();
        var año_name = date.getFullYear();
        var Mes = "";

        switch (MSelFront) {
            case "Enero":
                Mes = "02";
                break;
            case "Febrero":
                Mes = "03";
                break;
            case "Marzo":
                Mes = "04";
                break;
            case "Abril":
                Mes = "05";
                break;
            case "Mayo":
                Mes = "06";
                break;
            case "Junio":
                Mes = "07";
                break;
            case "Julio":
                Mes = "08";
                break;
            case "Agosto":
                Mes = "09";
                break;
            case "Septiembre":
                Mes = "10";
                break;
            case "Octubre":
                Mes = "11";
                break;
            case "Noviembre":
                Mes = "12";
                break;
            case "Diciembre":
                Mes = "01";
                break;
        }

        if (Mes == "01") {
            año_name = año_name + 1;
        }

        var newDate = año_name + "/" + Mes + "/" + fechaNum;
        Redirect(newDate);
    });

    //SEMANA 1
    $("#D1").click(function () {
        var fechaNum = $("#D1").val();
        ChangeDay(fechaNum);
    });

    $("#D2").click(function () {
        var fechaNum = $("#D2").val();
        ChangeDay(fechaNum);
    });

    $("#D3").click(function () {
        var fechaNum = $("#D3").val();
        ChangeDay(fechaNum);
    });

    $("#D4").click(function () {
        var fechaNum = $("#D4").val();
        ChangeDay(fechaNum);
    });

    $("#D5").click(function () {
        var fechaNum = $("#D5").val();
        ChangeDay(fechaNum);
    });

    $("#D6").click(function () {
        var fechaNum = $("#D6").val();
        ChangeDay(fechaNum);
    });

    $("#D7").click(function () {
        var fechaNum = $("#D7").val();
        ChangeDay(fechaNum);
    });

    //SEMANA 2
    $("#D8").click(function () {
        var fechaNum = $("#D8").val();
        ChangeDay(fechaNum);
    });

    $("#D9").click(function () {
        var fechaNum = $("#D9").val();
        ChangeDay(fechaNum);
    });

    $("#D10").click(function () {
        var fechaNum = $("#D10").val();
        ChangeDay(fechaNum);
    });

    $("#D11").click(function () {
        var fechaNum = $("#D11").val();
        ChangeDay(fechaNum);
    });

    $("#D12").click(function () {
        var fechaNum = $("#D12").val();
        ChangeDay(fechaNum);
    });

    $("#D13").click(function () {
        var fechaNum = $("#D13").val();
        ChangeDay(fechaNum);
    });

    $("#D14").click(function () {
        var fechaNum = $("#D14").val();
        ChangeDay(fechaNum);
    });

    //SEMANA 3
    $("#D15").click(function () {
        var fechaNum = $("#D15").val();
        ChangeDay(fechaNum);
    });

    $("#D16").click(function () {
        var fechaNum = $("#D16").val();
        ChangeDay(fechaNum);
    });

    $("#D17").click(function () {
        var fechaNum = $("#D17").val();
        ChangeDay(fechaNum);
    });

    $("#D18").click(function () {
        var fechaNum = $("#D18").val();
        ChangeDay(fechaNum);
    });

    $("#D19").click(function () {
        var fechaNum = $("#D19").val();
        ChangeDay(fechaNum);
    });

    $("#D20").click(function () {
        var fechaNum = $("#D20").val();
        ChangeDay(fechaNum);
    });

    $("#D21").click(function () {
        var fechaNum = $("#D21").val();
        ChangeDay(fechaNum);
    });

    //SEMANA 4
    $("#D22").click(function () {
        var fechaNum = $("#D22").val();
        ChangeDay(fechaNum);
    });

    $("#D23").click(function () {
        var fechaNum = $("#D23").val();
        ChangeDay(fechaNum);
    });

    $("#D24").click(function () {
        var fechaNum = $("#D24").val();
        ChangeDay(fechaNum);
    });

    $("#D25").click(function () {
        var fechaNum = $("#D25").val();
        ChangeDay(fechaNum);
    });

    $("#D26").click(function () {
        var fechaNum = $("#D26").val();
        ChangeDay(fechaNum);
    });

    $("#D27").click(function () {
        var fechaNum = $("#D27").val();
        ChangeDay(fechaNum);
    });

    $("#D28").click(function () {
        var fechaNum = $("#D28").val();
        ChangeDay(fechaNum);
    });

    //SEMANA 5
    $("#D29").click(function () {
        var fechaNum = $("#D29").val();
        ChangeDay(fechaNum);
    });

    $("#D30").click(function () {
        var fechaNum = $("#D30").val();
        ChangeDay(fechaNum);
    });

    $("#D31").click(function () {
        var fechaNum = $("#D31").val();
        ChangeDay(fechaNum);
    });

    $("#D32").click(function () {
        var fechaNum = $("#D32").val();
        ChangeDay(fechaNum);
    });

    $("#D33").click(function () {
        var fechaNum = $("#D33").val();
        ChangeDay(fechaNum);
    });

    $("#D34").click(function () {
        var fechaNum = $("#D34").val();
        ChangeDay(fechaNum);
    });

    $("#D35").click(function () {
        var fechaNum = $("#D35").val();
        ChangeDay(fechaNum);
    });

    function ChangeDay(fechaNum)
    {
        if (fechaNum.toString() == "") {
            return;
        }

        let meses = ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"];

        var x = document.getElementById("FSelFront");
        var YSelFront = $("#thisYear").val();
        let date = new Date(x.value.replace(/-+/g, '/'));

        var mes_name = date.getMonth();
        var Mes = "";

        switch (meses[mes_name]) {
            case "Enero":
                Mes = "01";
                break;
            case "Febrero":
                Mes = "02";
                break;
            case "Marzo":
                Mes = "03";
                break;
            case "Abril":
                Mes = "04";
                break;
            case "Mayo":
                Mes = "05";
                break;
            case "Junio":
                Mes = "06";
                break;
            case "Julio":
                Mes = "07";
                break;
            case "Agosto":
                Mes = "08";
                break;
            case "Septiembre":
                Mes = "09";
                break;
            case "Octubre":
                Mes = "10";
                break;
            case "Noviembre":
                Mes = "11";
                break;
            case "Diciembre":
                Mes = "12";
                break;
        }

        var newDate = YSelFront + "/" + Mes + "/" + fechaNum.toString();
        Redirect(newDate);
    }

    function Redirect(Fecha) {
        window.location.replace("https://localhost:44396?F=" + Fecha);
    }
});