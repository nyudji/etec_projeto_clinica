<!DOCTYPE html "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>A Clina SONA</title>
    <link href="css/clinica.css" rel="stylesheet" type="text/css"/>

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

	    	<div id="Especialidades">
				<img src="image/clinica.jpg" width="250" height="700"/>
		    </div>

		    <div id="Clinica">
                <p><b>A CLÍNICA SONA</b> – Vida e Saúde, possui 1 endereço, onde profissionais, de várias áreas da saúde, experientes e com formação sólida, oferecem serviços multidisciplinares para atender as necessidades ou anseios de todos aqueles que buscam ampliar a sua qualidade de vida, seu bem-estar e a sua saúde de modo geral.</p>
                <p>Somos psicólogos, médicos psiquiatras, fisioterapeutas, Fonoaudiólogos, nutricionistas, psicopedagogos, profissionais das terapias naturais e alternativas, orientadores de carreira, coaches e muitos outros, cujo foco é desempenhar bem o papel de facilitadores e agentes da promoção da saúde, particularmente, a saúde psicológica, tão importante para a nossa percepção de bem-estar e equilíbrio geral.</p>
		    </div>

            <div id="Foto1" class="ft">
                <img src="image/1.jpg" width="300" height="250"/>
            </div>

            <div id="Foto2" class="ft1">
                <img src="image/2.jpg" width="300" height="250"/>
            </div>

            <div id="Foto3" class="ft2">
                <img src="image/4.jpg" width="300" height="250"/>
            </div>

        </div>
        
        <div id="Rodape">
			<p><b>© 2013 Copyright Clínica Sona</b> - Nicolas Yudji / Venâncio</p>
        </div>

	</div>

</body>
</html>
