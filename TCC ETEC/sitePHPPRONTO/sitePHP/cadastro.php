<?php 
include("includes/header.php");
?>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Cadastro</title>
    <link href="css/cadastro.css" rel="stylesheet" type="text/css"/>

    <!--Slide Show-->
        <script type="text/javascript" src="js/jquery.js" ></script>
		<script type="text/javascript" src="js/jquery.easing.1.3.js" ></script>
		<script type="text/javascript" src="js/cycle.js"></script>

            <script>
                $(document).ready(function () {
					
                    slideShow();

                });

                function slideShow() {

                    //Opacidade de todas as imagens
                    $('#slideshow a').css({ opacity: 0.0 });

                    $('#slideshow a:first').css({ opacity: 1.0 });

                    //mudança para a imagem seguinte após 6 segundos
                    setInterval('slideshow()', 3000);

                }
function Nova(){
location.href="cadastro.php"
} 
                function slideshow() {

                    //if no IMGs  ter a classe show, pegar a primeira imagem nb
                    var current = ($('#slideshow a.show') ? $('#slideshow a.show') : $('#slideshow a:first'));

                    //Obter imagem seguinte, se chegou ao final da apresentação de slides, girá-lo de volta para a primeira imagem
                    var next = ((current.next().length) ? ((current.next().hasClass('caption')) ? $('#slideshow a:first') : current.next()) : $('#slideshow a:first'));

                    //Obter legenda da imagem ao lado
                    var caption = next.find('img').attr('rel');

                    //Definir o desbotamento em vigor para a próxima imagem
                    next.css({ opacity: 0.0 })
                    .addClass('show')
                    .animate({ opacity: 1.0 }, 1000);

                    //Ocultar a imagem atual
                    current.animate({ opacity: 0.0 }, 1000)
                    .removeClass('show');
                }

</script>

<!--Fim slide show-->

</head>

<body>

    <div id="master">

        <div id="Topo">
            <div id="Logo">
                <img src="image/logo.jpg" width="300" height="180"/>
            </div>

            <div id="Name">
                <div id="slideshow">
    							<a href="#" class="show">
								<img src="image/7.jpg" title=""/>
								</a>
	
								<a href="#" class="show">
								<img src="image/5.jpg" title="" alt="" />
								</a>

								<a href="#" class="show">
								<img src="image/3.jpg" title="" alt="" /> 
								</a>

								<a href="#" class="show">
								<img src="image/6.jpg" title="" alt=""/>
								</a>
 				 </div>
            </div>

            <div id="Login">
                <p><h2 class="titulo">Área de login</h2></p>
                <form name="lg" class="login" method="post" action="autorizacao.php">
                    <ul>			
                        <li>E-mail: <input type="text" id="email" name="email" placeholder="Email" class="email" /></li>
                        <li>Senha: <input type="password" id="senha" name="senha" placeholder="Senha" class="senha"/></li>
			<li><a class="esp"href="#" class="esp">Esqueceu sua senha ? </a></li>
                        <li align="right"><br><input type="submit" name="enviar" value="Entrar"  class="botao"/><input type="button" name="cadastrar" value="Cadastro" class="botao"  onClick="Nova()"/></li>
                    </ul>
                </form>
            </div>


        </div>
		
	

		<div id="Menu-top">
            <nav>
                <ul>
                    <li><a href="home.php">Home</a>
                    <a href="clinica.php">| Clínica</a>
                    <a href="convenio.php">| Convênios</a>
                    <a href="contato.php">| Contato</a>
                    <a href="localizacao.php">| Localização</a></li>
                </ul>
            </nav>
		</div>

		<div id="Conteudo">
			<div id="Fotoconvenio1" class="foto">
				<img src="image/convenio2.jpg" width="250" height="570"/>
			</div> 
		<div id="Info">
          <form method="post" action="?acao=cadastrar">
<div class="message" style="<?php echo $display?>"> <?php  echo $msg ?> </div>
		<h4>Cadastro de paciente </h4><hr><br>
        
 

		 <table style="width: 500px" border="0">


    <tbody>

             
    <tr>

      <td width="69">Nome:</td>

      <td width="400"><input id="nome" maxlength="60" name="nome" size="50" type="text" />

        <span class="style1">*</span></td>

    </tr>
    <tr>

      <td width="69">RG:</td>

      <td width="400"><input id="rg" maxlength="13" name="rg" size="20" type="text" />

        <span class="style1">*</span></td>

    </tr>
      <td width="69">CPF:</td>

      <td width="400"><input id="cpf" maxlength="11" name="cpf" size="20" type="text" />

        <span class="style1">*</span></td>

    </tr>
	
     </tr>
      <td width="69">Dt Nascimento:</td>

      <td width="400"><input id="dtnas" maxlength="30" name="dtnas" size="30" type="text" />

        <span class="style1">*</span></td>

    </tr>

	
	
    <tr>

      <td>DDD:</td>

      <td><input id="ddd" maxlength="2" name="ddd" size="4" type="text" />

      Telefone:

        <input id="telefone" name="telefone" type="text" />

        <span class="style3">Apenas números</span><br> </td>

    </tr>

    <tr>

      <td>Endereço:</td>

      <td><input id="endereco" maxlength="70" name="endereco" size="30" type="text" /> nº<input id="numeroend" maxlength="20" name="numeroend" size="5" type="text"/>
        <span class="style1">*</span></td>

    </tr>

    <tr>

      <td>Cidade:</td>

      <td><input id="cidade" maxlength="20" name="cidade" type="text" />

        <span class="style1">*</span></td>

    </tr>

 </tr>
      <td width="69">Estado:</td>

      <td width="400"><input id="estado" maxlength="11" name="estado" size="20" type="text" />

        <span class="style1">*</span></td>

    </tr>

    <tr>

      <td>Bairro:</td>

      <td><input id="bairro" maxlength="20" name="bairro" type="text" />

        <span class="style1">*</span></td><br>

    </tr>

    <tr>

      <td>País:</td>

      <td><input id="pais" maxlength="20" name="pais" type="text" />

        <span class="style1">*</span></td>

    </tr>

    <tr>

      <td>Email:</td>

      <td><input id="email" maxlength="60" name="email" size="40" type="text" />

      <span class="style1">*</span></td>

    </tr>

    <tr>

      <td>Senha:</td>

      <td><input id="senha" maxlength="90" name="senha" type="password" />

          <span class="style1">*</span></td>

    </tr>

    <tr>

      <td colspan="2"><p>


<br>

        <input id="cadastrar" name="cadastrar" type="submit" value="Cadastrar" /> 

        



          <input id="limpar" name="limpar" type="reset" value="Limpar" />

          



          <span class="style1">* Campos com * são obrigatórios!          </span></p>

      <p> </p></td>

    </tr>


  </tbody></table>



</form>

		</div>
				
		<div id="Rodape">
			<p><b>© 2013 Copyright Clínica Sona</b> - Nicolas Yudji / Venâncio</p>
		</div>
		
	</div>


</body>
</html>
