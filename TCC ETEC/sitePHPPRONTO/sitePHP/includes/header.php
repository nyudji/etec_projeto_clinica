<?php
//Starts
ob_start();
session_start();

//Globais
include("globais.php");

//Include das classes
include("classes/DB.class.php");
include("classes/Cadastro.class.php");
include("classes/Login.class.php");
include("classes/Consulta.class.php");

//Conexão com o banco de dados
$conectar=new DB;
$conectar=$conectar->conectar();

//Métodos
include("controllers/consulta.php");
include("controllers/cadastro.php");
include("controllers/check.php");
include("controllers/style.php");
include("controllers/cadastro.php");
include("controllers/login.php");
include("controllers/logout.php");
include("controllers/aprovar.php");
?>