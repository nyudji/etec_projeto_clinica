<!DOCTYPE html "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>ESTRUTURA</title>
    <link href="css/home.css" rel="stylesheet" type="text/css"/>

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
                <p><h1 class="titulo">Área de login</h1></p>
                <form method="post" action="?acao=logar">
                    <ul>			
                        <li>E-mail: <input type="text" id="email" name="email" placeholder="Email" class="email" /></li>
                        <li>Senha: <input type="password" id="senha" name="senha" placeholder="Senha" class="senha"/></li>
			<li><a class="esp"href="#" class="esp">Esqueceu sua senha ? </a></li>
                        <li align="right"><br><input type="button" name="cadastrar" value="Cadastro" class="botao"  onClick="Nova()"/><input type="submit" name="enviar" value="Entrar"  class="botao"/></li>
                    </ul>
                </form>
            </div>

        </div>
		

	<div class="msg"><?php echo $msg ?></div>
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
                
                <div id="Medicos">
				<button><b><h1>Nossos médicos</h1></b><hr><b>Conheça-os</b></button>
                    <div id="MedicoInfo1">
						<img src="image/medico1.jpg"/>
						<a href="drfranco.php"><img src="image/saiba.png"/></a>
                    </div>
                    
                    <div id="MedicoInfo2">
						<img src="image/medico2.jpg"/>
						<a href="drsergio.php"><img src="image/saiba.png"/></a>
                    </div>
                </div>

                <div id="Informaçao">
                    <div id="ResumoClinica">
                        <div id="FotoClinica1">
                           <img src="image/2.jpg" width="200" height="130"/>
                        </div>
                        <div id="FotoClinica2">
                            <img src="image/4.jpg" width="200" height="130"/>
                        </div>
                        <div id="Botao">
                            <a href="clinica.php"><button><b>Conheça nossa clínica</b><hr><b>Clique aqui</b></button></a>
							<h4>Clínica Sona, um espaço para cuidar da sua saúde e bem-estar</h4>
                        </div>
                    </div>
					
					<div id="ResumoConvenio">
						<div id="FotoConvenio">
							<img src="image/FotoConvenio.jpg" width="200" height="130"/>
						</div>
						<div id="InfoConvenio">
							<p><h4>A Clínica Sona está no processo de ampliação de seu complexo,
							estendendo ainda mais seu atendimento nas mais diversas especialidades médicas.</h4></p>
						</div>
						<div id="Botao">
                            <a href="convenio.php"><button><b>Conheça nossos convênios</b><hr><b>Clique aqui</b></button></a>
                        </div>
					</div>
					
					<div id="ImagemMissao">
						<img src="image/missao.jpg"/ width="650" height="230">
					
                    <p><b>EXCELÊNCIA.</b> É a nossa meta. A Clínica Sona procura unir o que há de mais moderno e avançado em medicina diagnóstica à constante 
					formação e capacitação de seus profissionais, sem abandonar a tradição do bom atendimento, daquela consulta em que a paciente é examinada, 
					esclarecida quanto às suas dúvidas e queixas, e informada como melhorar sua saúde, seja na adolescência, na fase adulta ou na terceira 
					idade. Essa união entre modernidade e tradição possibilita o surgimento de um vínculo verdadeiro.</p>
					</div>
                </div>
		</div>

		<div id="Rodape">
			<p><b>© 2013 Copyright Clínica Sona</b> - Nicolas Yudji / Venâncio</p>
		</div>

	</div>

</body>
</html>