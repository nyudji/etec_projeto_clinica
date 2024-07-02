<?php
if($startaction == 1 && $acao == "cadastrar"){
			$nome=$_POST["nome"];
			$rg=$_POST["rg"];
			$cpf=$_POST["cpf"];
			$dtnas=$_POST["dtnas"];
			$ddd=$_POST["ddd"];
			$telefone=$_POST["telefone"];
			$endereco=$_POST["endereco"];
			$numeroend=$_POST["numeroend"];
			$cidade=$_POST["cidade"];
			$estado=$_POST["estado"];
			$bairro=$_POST["bairro"];
			$pais=$_POST["pais"];
			$email=$_POST["email"];
			$senha=$_POST["senha"];	
		
		if(empty($nome) || empty($rg) || empty($cpf)  || empty($dtnas)|| empty($ddd) || empty($telefone) || empty($endereco) || empty($numeroend) || empty($cidade)|| empty($estado)|| empty($bairro) || empty($pais) || empty($email)|| empty($senha)){
			$msg="Preencha todos os campos!";
		}
		//Todos os campos preenchidos
		else{
			//Email válido
			if(filter_var($email,FILTER_VALIDATE_EMAIL)){
				//Senha inválida
				if(strlen($senha) < 8){
					$msg="As senhas devem ter no mínimo oito caracteres!";
				}
				//Senha válida
				else{
					//Executa a classe de cadastro
					$conectar=new Cadastro;
					echo $msg;
					$conectar=$conectar->cadastrar($nome, $rg, $cpf, $dtnas ,$ddd, $telefone, $endereco, $numeroend, $cidade, $estado, $bairro,$pais, $email, $senha); 

				}
			}
			//E-mail inválido
			else{
				$msg="Digite seu e-mail corretamente!";
			}
		}
}

?>