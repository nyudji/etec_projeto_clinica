<?php
	class Cadastro{
		public function cadastrar($nome, $rg, $cpf, $dtnas, $ddd, $telefone, $endereco, $numeroend, $cidade, $estado, $bairro, $pais, $email, $senha){

			//Inserção no banco de dados
			$validaremail=mysql_query("SELECT * FROM paciente WHERE email='$email'");
			$contar=mysql_num_rows($validaremail);
			if($contar == 0){
			$insert=mysql_query("INSERT INTO paciente (nome, rg , cpf, dtnas, ddd, telefone, endereco, numeroend, cidade, estado, bairro, pais ,email, senha, nivel)VALUE('$nome','$rg','$cpf','$dtnas','$ddd','$telefone','$endereco','$numeroend','$cidade','$estado','$bairro','$pais','$email','$senha',1)");}else{
			$msg="Desculpe, mas já existe um usuário cadastrado com este e-mail em nosso sistema!";
			}
			if(isset($insert)){
				$msg="Cadastro realizado com sucesso!";
			}else{
				if(empty($msg)){
				$msg="Ops! Houve um erro em nosso sistema, contate o administrador!";
				}
			}
			
			//Retorno para o usuário
			echo $msg;
		}
	
	}

?>