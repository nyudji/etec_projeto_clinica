<?php
if($startaction == 1 && $acao == "aprovar"){
		if($nivel == 2){
			if(isset($_GET["id"])){
				$id=$_GET["id"];
				$query=mysql_query("UPDATE consultas SET status='1' WHERE ID='$id'");
			}
		}
}
?>