<?php
	class Login{
		public function logar($email, $senha){
			$buscar=mysql_query("SELECT * FROM paciente WHERE email='$email' AND senha='$senha'  LIMIT 1");
			if(mysql_num_rows($buscar) == 1){
				$dados=mysql_fetch_array($buscar);
					$_SESSION["nome"]=$dados["nome"];
					$_SESSION["email"]=$dados["email"];
					$_SESSION["senha"]=$dados["senha"];
					$_SESSION["nivel"]=$dados["nivel"];
					setcookie("logado",1);
					$log=1;
		
			}
				if(isset($log)){
					$msg="Você foi logado com sucesso";
				}else{
					if(empty($msg)){
					$msg="Ops! Digite seu e-mail e sua senha corretamente!";
					}						
				}
return $msg;
		}
	
	}