<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Convenios</title>
    <link href="css/convenio.css" rel="stylesheet" type="text/css"/>

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

            < <div id="Login">
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
				<img src="image/convenio1.jpg" width="250" height="570"/>
			</div> 
			<div id="Convenio1">
                    Abet / Plantel         
                    <br />Alvorecer / Blue Med 
                    <br />Amesp 
                    <br />Bio Saúde 
                    <br />Bradesco 
                    <br />Care Plus 
                    <br />CETESB 
                    <br />Correios 
                    <br />Dix Saúde 
                    <br />Fundação CESP 
                    <br />Golden Cross 
                    <br />Intermédica 
                    <br />Lincx 
                    <br />Medial 
                    <br />Medservice 
                    <br />Notre Dame 
                    <br />Petrobrás Distribuidora 
                    <br />Porto Seguro 
                    <br />Sabesprev 
                    <br />Saúde Medicol 
                    <br />Sepaco 
                    <br />Tempo Saúde ,(Unibanco) 
                    <br />Transmontano 
                    <br />Unimed Intercâmbio 
                    <br />Universal Saúde 
			</div>

            
			<div id="Convenio2">
                    Allianz 
                    <br />Ameplan / Royal Saúde 
                    <br />Amil 
                    <br />Blue Life 
                    <br />Cabesp 
                    <br />Central Nacional Unimed 
                    <br />Classes Laboriosas 
                    <br />Cruz Azul 
                    <br />Economus 
                    <br />Gama Saúde 
                    <br />Green Line 
                    <br />Life Empresarial 
                    <br />Marítima 
                    <br />Medical Health 
                    <br />Metrus 
                    <br />Omint / Skill 
                    <br />Petrobrás Petróleo 
                    <br />Portomed 
                    <br />São Cristóvão 
                    <br />Seisa 
                    <br />Sul América 
                    <br />Transeguro 
                    <br />Unimed Fesp 
                    <br />Unimed Paulistana 
                    <br />Volkswagen 
			</div>
			<div id="Fotoconvenio2" class="foto">
				<img src="image/convenio2.jpg" width="250" height="570"/>
			</div>

		</div>
				
		<div id="Rodape">
			<p><b>© 2013 Copyright Clínica Sona</b> - Nicolas Yudji / Venâncio</p>
		</div>
		
	</div>

</body>
</html>
