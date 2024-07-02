<?php include"includes/header.php"?>
<?php $emailid=$_SESSION["nome"];?>

<!DOCTYPE html "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>ESTRUTURA</title>
    <link href="css/consulta.css" rel="stylesheet" type="text/css"/>

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
                <p style="font-size:25px;font-family:Tahoma, Geneva, sans-serif" class="oi"><?php echo "Bem vindo $emailid" ?></p>
  <form method="post" action="?acao=logout">
                 
             <div id="cadastrar"> 
<a href="marcarconsulta.php">Marque sua consulta</a> <br /><br /><a href="agendadas.php">Cosultas(Agendadas)</a></div><a class="botao2" href="home.php?acao=logout">Logout</a> 

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
			<div id="FotoConsulta2">

                <img src="image/consulta2.jpg" width="350" height="220"/>
                <div id="FotoConsulta">

                <img src="image/consulta.jpg" width="350" height="220"/>
            </div>
            </div>
                <div id="Consulta">
        <p class="titulo1">         	<div class="message" style="<?php echo $display?>"> <?php  echo $msg ?> </div>        	<p echo "Agendamento de consulta" ?></p><hr /><br />
                <form method="post" action="?acao=consultar"><table style="width: 500px" border="0">
   
  <tr>
  
      <td width="400"><input class="input" id="nome" maxlength="50" name="nome" size="50" type="text" placeholder="Nome" />

        <span class="style1">*</span></td>

    </tr>
      <tr>
  
      <td width="400"><input class="input" id="cpf" maxlength="50" name="cpf" size="50" type="text" placeholder="CPF" />

        <span class="style1">*</span></td>

    </tr>
          <tr>
  
      <td width="400"><select id="nomedr" name="nomedr" type="text" placeholder="Doutor"  class="input">
      <option id="nomedr" value="Dr.Marcos">Dr.Marcos</option>
      <option id="nomedr" value="Dr.Francisco">Dr.Francisco</option>
      <option d="nomedr" value="Dra.Andréia">Dra.Andréia</option>
      <option d="nomedr" value="Dr.Priscila">Dr.Priscila</option>
      <option d="nomedr" value="Dr.Carla">Dr.Carla</option>
      <option d="nomedr" value="Dr.Edith">Dr.Edith</option>
      
      
      </select>

        <span class="style1">*</span></td>

    </tr>
        <tr>
  
      <td width="400"><input class="input" id="data" maxlength="50" name="data" size="50" type="text" placeholder="Data" />

        <span class="style1">*</span></td>

    </tr>
        <tr>
  
      <td width="400"><input class="input" id="horario" maxlength="50" name="horario" size="50" type="text" placeholder="Horário" />

        <span class="style1">*</span></td>

    </tr>
               </table>
                <input id="agendar" name="agendar" type="submit" value="Agendar" style="margin-left:70px;margin-top:50px;width:100px;height::150px;border-radius:3px" /><input id="limpar" name="limpar" type="reset" value="Limpar" style="margin-left:50px;width:100px;border-radius:3px"/>         
               
                </div>
              

		</div>
   </form>
		<div id="Rodape">
			<p><b>© 2013 Copyright Clínica Sona</b> - Nicolas Yudji / Venâncio</p>
		</div>

	</div>

</body>
</html>