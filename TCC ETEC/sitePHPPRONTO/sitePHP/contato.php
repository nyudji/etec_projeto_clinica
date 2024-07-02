<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Localizaçao</title>
    <link href="css/contato.css" rel="stylesheet" type="text/css"/>

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

               <div id="Box">
                        
                    <div id="Mentalist" class="caixa">
                        <p><b><h1>The Mentalist</h1></b></p>
                        <br /><p>Caso tenha algo não esclarecido, alguma dúvida, estaremos dispostos a atendê-los. Basta preencher os campos ao lado e enviar o formulário.</p>

                    </div>

                    <div id="FaleConosco" class="caixa">
                        <p><b><h1>Fale Conosco</h1></b></p>
                        <form name="faleconosco">
                            <ul>
                                <br />Nome<li><input type="text" name="nome" placeholder="Nome"/></li>
                                Email<li><input type="text" name="email" placeholder="Email"/></li>
                                Telefone<li><input type="text" name="telefone" placeholder="Telefone"/></li>
                                Mensagem<li><textarea type="mytextarea" placeholder="Mensagem" cols="20" rows="5"></textarea></li>

                                <br /><li><input type="submit" name="enviar" value="Enviar" class="botao"/> <input type="reset" name="limpar" value="Limpar" class="botao" /></li>

                            </ul>
                        </form>
                    </div>

                    <div id="Contato" class="caixa">
                        <p><b><h1>Contato</h1></b></p>
                        <br /><p>Rua Pedroso Alvarenga, 1046
                        <br />Itaim - São Paulo-SP
                        <br />Cep: 04531- 004</p>
                        <p><b>Celular:</b> +55(11)97292-0000
                        <br /><b>Telefone:</b> +55(11)3596-9635
                        <br /><b>E-mail:</b> nicolas.yudji@hotmail.com
                        </p>
                        
                    </div>
                </div>
		</div>

		<div id="Rodape">
			<p><b>© 2013 Copyright Clínica Sona</b> - Nicolas Yudji / Venâncio</p>
		</div>

	</div>

</body>
</html>
