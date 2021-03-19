<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="ProjetoFacilAssist.Cadastro" %>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <!-- Meta tags Obrigatórias -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <title>ProjectFacilAssist</title>
</head>
<body>
    <style>
        .formulario {
            padding-right: 20px;
            padding-left: 20px;
            padding-top: 20px;
            padding-bottom: 20px;
        }

        .border {
            animation: animated-border 1.5s infinite;
            font-size: 18px;
            line-height: 30px;
            font-weight: bold;
            border: 2px solid;
            border-radius: 10px;
            padding: 15px;
            background-color: white;
        }

        @keyframes animated-border {
            0% {
                box-shadow: 0 0 0 0 rgba(255,255,255,0.2);
            }

            100% {
                box-shadow: 0 0 0 20px rgba(255,255,255,0);
            }
        }

        body {
            background: #6093E7;
        }
    </style>

    <form class="formulario">
        <div id="conteudo" class="border border-primary">
            <div class="form-row">
                <div class="form-group col-md-6">
                    <label for="inputNome">Nome</label>
                    <input type="text" class="form-control" id="inputNome" maxlength="50" placeholder="Nome">
                </div>
                <div class="form-group col-md-3">
                    <label for="inputCPF">CPF</label>
                    <input type="text" class="form-control" id="inputCPF" placeholder="CPF" onkeydown="javascript: fMasc( this, mCPF )" maxlength="14">
                </div>
                <div class="form-group col-md-3">
                    &nbsp;
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="Ativo" checked>
                    <label class="form-check-label" for="Ativo">
                        Ativo
                    </label>
                </div>
                </div>
            </div>
            <div class="form-row">
                <div class="form-group col-md-6">
                    <div class="form-check form-check-inline">
                        <input class="form-check-input" type="radio" name="TipoCliente" id="inlineRadio1" value="option1">
                        <label class="form-check-label" for="inlineRadio1">Pessoa Física</label>
                    </div>
                    <div class="form-check form-check-inline">
                        <input class="form-check-input" type="radio" name="TipoCliente" id="inlineRadio2" value="option2">
                        <label class="form-check-label" for="inlineRadio2">Pessoa Jurídica</label>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <div class="form-check form-check-inline">
                        <input class="form-check-input" type="checkbox" id="SexoMasculino" name="Sexo" value="M">
                        <label class="form-check-label" for="SexoMasculino">Masculino</label>
                    </div>
                    <div class="form-check form-check-inline">
                        <input class="form-check-input" type="checkbox" id="SexoFeminino" name="Sexo" value="F">
                        <label class="form-check-label" for="SexoFeminino">Feminino</label>
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <button type="button" id="btn_new" class="btn btn-primary">Novo</button>
                    <button type="button" class="btn btn-success">Gravar</button>
                </div>
            </div>
        </div>
    </form>

    <!-- JavaScript (Opcional) -->
    <!-- jQuery primeiro, depois Popper.js, depois Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

    <script type="text/javascript">

        /**
         * Máscara para validar o CPF em JAVASCRIPT
         * */
        function ValidaCPF() {
            var RegraValida = document.getElementById("inputCPF").value;
            var cpfValido = /^(([0-9]{3}.[0-9]{3}.[0-9]{3}-[0-9]{2})|([0-9]{11}))$/;
            if (cpfValido.test(RegraValida) == true) {
                console.log("CPF Válido");
            } else {
                console.log("CPF Inválido");
            }
        }

        function fMasc(objeto, mascara) {
            obj = objeto
            masc = mascara
            setTimeout("fMascEx()", 1)
        }

        function fMascEx() {
            obj.value = masc(obj.value)
        }

        function mCPF(cpf) {
            cpf = cpf.replace(/\D/g, "")
            cpf = cpf.replace(/(\d{3})(\d)/, "$1.$2")
            cpf = cpf.replace(/(\d{3})(\d)/, "$1.$2")
            cpf = cpf.replace(/(\d{3})(\d{1,2})$/, "$1-$2")
            return cpf
        }

        $('#btn_new').click(function () {
            $(':input').val('');
            $('#Ativo').prop('checked', true);
            $("[name='TipoCliente']").val(null).prop('checked', false).trigger("liszt:updated");
            $("[name='Sexo']").val(null).prop('checked', false);
        });

    </script>
</body>
</html>

