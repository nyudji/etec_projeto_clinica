-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 03-Fev-2014 às 12:47
-- Versão do servidor: 5.6.12-log
-- versão do PHP: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `thementalist`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `paciente`
--

CREATE TABLE IF NOT EXISTS `paciente` (
  `id` int(1) NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `rg` varchar(20) NOT NULL,
  `cpf` varchar(20) NOT NULL,
  `dtnas` varchar(20) NOT NULL,
  `ddd` varchar(5) NOT NULL,
  `telefone` varchar(20) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `numeroend` varchar(20) NOT NULL,
  `cidade` varchar(30) NOT NULL,
  `estado` varchar(20) NOT NULL,
  `bairro` varchar(30) NOT NULL,
  `pais` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  `senha` varchar(100) NOT NULL,
  `nivel` int(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Extraindo dados da tabela `paciente`
--

INSERT INTO `paciente` (`id`, `nome`, `rg`, `cpf`, `dtnas`, `ddd`, `telefone`, `endereco`, `numeroend`, `cidade`, `estado`, `bairro`, `pais`, `email`, `senha`, `nivel`) VALUES
(9, 'Ana', '418757896', '268.766.338-70', '16/08/1996', '11', '2994-5584', 'Rua dos Maracujas', '153', 'Sao Paulo', 'SP', 'Villa Medeiros', 'Brasil', 'secretaria@sona.com', '123456789', 2),
(10, 'Matheus', '403289440', '286.485.869-09', '17/01/1994', '11', '95610-2214', 'Av Coronel Sezefredo Fagundes', '152', 'Sao Paulo', 'SP', 'Cachoeira', 'Brasil', 'mat@hotmail.com', '123456789', 1),
(11, 'Aline', '418757896', '843.355.967-23', '16/12/1994', '11', '29947451', 'Av Maria Malha', '14123', 'Sao Paulo', 'SP', 'Jardim Brasil', 'Brasil', 'aline@hotmail.com', '123456789', 1);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
