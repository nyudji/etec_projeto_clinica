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
  <form method="post" action="">
                 
           <div id="cadastrar2"> 
<a href="secretaria.php">Consultas</a></div><a class="botao2" href="home.php?acao=logout">Logout</a> 

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
                <form method="post" action="">			<table width="300px" border="0">
            	<tr>
                	<th>Nome</th>
                    <th>Status</th>
                    <th>Data</th>
                    <th>Horário</th>
                </tr>
                <?php
				$nomee=$_SESSION["nome"];
				$buscarusuarios=mysql_query("SELECT * FROM consultas WHERE status=0");
				if(mysql_num_rows($buscarusuarios) == 0){
				echo"Nenhuma consulta cadastrada no sistema!";
				}else{
					while($linha=mysql_fetch_array($buscarusuarios)){
				?>
                <tr>
                	<td><?php echo $linha["nome"];?></td>
                    <td><?php echo $linha["status"];?></td>
                    <td><?php echo $linha["data"];?></td>
                    <td><?php echo $linha["horario"];?></td>
                    <td><?php $id=$linha["ID"];  echo "<a href=\"home.php?acao=aprovar&amp;id=$id\">Aprovar</a>";}?></td>
                    
                </tr>
                <?php  }?>
            </table>
              
                      
               
                </div>
              

		</div>
      
   </form>
		<div id="Rodape">
			<p><b>© 2013 Copyright Clínica Sona</b> - Nicolas Yudji / Venâncio</p>
		</div>

	</div>

</body>
</html>