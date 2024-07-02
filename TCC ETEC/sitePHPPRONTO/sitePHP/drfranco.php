

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>ESTRUTURA</title>
    <link href="css/drfranco.css" rel="stylesheet" type="text/css"/>

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
                
                <div id="Medicos">
				<p style="margin-left:20px">Psicologos</p><hr>
                    <div id="MedicoInfo1">
					<a href="drfranco.php"><img src="image/medico1.jpg"></a> 
                    </div>
			
                    
                    <div id="MedicoInfo2">
						<a href="drsergio.php"><img src="image/medico2.jpg"></a> 

                    </div>
                </div>

                <div id="Informaçao">
                  
					<div id="ResumoConvenio">
						<div id="FotoConvenio">
							<img src="image/medico1.jpg" width="200" height="130"/>
						</div>
						<div id="InfoConvenio">
							<p><h4 style="font-size:32px;color:blue">Dr. Franco Loeb Chazan </h4></p>
						</div>
	
					</div>
					
					<div id="ImagemMissao">
			
					
<p style="font-size:18px">Psicoterapeuta, Neuropsicólogo e Mestre em Cognição e Neurociências do Comportamento pela Universidade de Brasília - UnB.

Atende criança, adolescente, adulto, idoso e casal.

Realiza avaliação neuropsicológica.

Possui experiência prática e acadêmica em atendimento clínico, avaliação e reabilitação neuropsicológica pelo Hospital Universitário de Brasília - HUB e pelo Instituto Brasileiro de Neuropsicologia e Ciências Cognitivas - IBNeuro

Aplicadora do Programa de Enriquecimento Instrumental - PEI I e II (Instrumento utilizado para reabilitar e intensificar as funções cognitivas).

Ênfase na intervenção psicoterápica e avaliação neuropsicológica, da personalidade e reabilitação cognitiva de adultos e de idosos.

Atua principalmente em casos de queixas de memória, perda de autonomia, depressão, ansiedade, desempenho em atividades diárias e demais transtornos de humor, decorrentes de lesões adquiridas, processos emocionais/comportamentais ou processos degenerativos.

Vasta prática na avaliação e no tratamento de crianças com dificuldades escolares e queixas de déficits de atenção e hiperatividade, assim como em outros transtornos específicos da infância.
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
?>