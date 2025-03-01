-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 02/09/2024 às 12:33
-- Versão do servidor: 10.4.22-MariaDB
-- Versão do PHP: 8.1.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `dsteste`
--

-- --------------------------------------------------------

--
-- Estrutura stand-in para view `aaa`
-- (Veja abaixo para a visão atual)
--
CREATE TABLE `aaa` (
`nome_aluno` varchar(100)
,`id` int(11)
,`nome_turma` varchar(100)
);

-- --------------------------------------------------------

--
-- Estrutura stand-in para view `aaa2`
-- (Veja abaixo para a visão atual)
--
CREATE TABLE `aaa2` (
`nome_professor` varchar(100)
,`id` int(11)
,`nome_turma` varchar(100)
);

-- --------------------------------------------------------

--
-- Estrutura para tabela `aluno`
--

CREATE TABLE `aluno` (
  `codaluno` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `rg` varchar(20) NOT NULL,
  `ra` varchar(20) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `cidade` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `telefone` varchar(30) NOT NULL,
  `turma` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `aluno`
--

INSERT INTO `aluno` (`codaluno`, `nome`, `rg`, `ra`, `endereco`, `cidade`, `email`, `telefone`, `turma`) VALUES
(0, 'nome', 'rg', 'ra', 'endereco', 'cidade', 'email', 'telefone', 'ada'),
(5, 'Patrick', '5555555555', '66666666666', 'dfffgdgd', 'dfgdfgdg', 'dfsfsfsf@dsfsf', '19213845465', ''),
(6, 'Caio', '777777777777', '888888888888', 'dfdsfsfsfds', 'dsfsdsfdsf', 'dfsdfsfsfdf@fsdf', '168098447', ''),
(7, 'p', '2', '3', 'df', 'gh', 'sdfg@sad', '12345', 'b'),
(8, 'patrick eee', '222222222277', '33333333333344', 'asdddff', 'asdsadsad', 'asdasd@fsd', '1245654789', 'b'),
(9, 'aasdsad', '121322', '2454243', 'asdfdaf', 'sadsad', 'asdad', '313433525', 'ada'),
(10, 'qqqqqqq', '111111111', '222222222', 'aasas', 'sasasa', 'asasa', '1123213', 'a'),
(12, 'pedreo3', '', '', '', '', '', '', 'a');

-- --------------------------------------------------------

--
-- Estrutura para tabela `aluno_turma`
--

CREATE TABLE `aluno_turma` (
  `codigo` int(11) NOT NULL,
  `codaluno` int(11) NOT NULL,
  `codturma` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `aluno_turma`
--

INSERT INTO `aluno_turma` (`codigo`, `codaluno`, `codturma`) VALUES
(1, 0, 1),
(3, 5, 3),
(5, 12, 2);

-- --------------------------------------------------------

--
-- Estrutura para tabela `expediente`
--

CREATE TABLE `expediente` (
  `codigo` int(11) NOT NULL,
  `codhorario` int(11) NOT NULL,
  `codfunc` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura para tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `codfunc` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `rg` varchar(20) NOT NULL,
  `cpf` varchar(20) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `cidade` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `telefone` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `funcionario`
--

INSERT INTO `funcionario` (`codfunc`, `nome`, `rg`, `cpf`, `endereco`, `cidade`, `email`, `telefone`) VALUES
(0, 'nome', 'rg', 'cpf', 'endereco', 'cidade', 'email', 'telefone'),
(4, 'aaaaaaaaa', '1111112222222', '33333333311111111', 'asdasd', 'asdadada', 'daaad@asda', '12345678');

-- --------------------------------------------------------

--
-- Estrutura para tabela `horario`
--

CREATE TABLE `horario` (
  `codhorario` int(11) NOT NULL,
  `periodo` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura para tabela `professor`
--

CREATE TABLE `professor` (
  `codprof` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `rg` varchar(20) NOT NULL,
  `cpf` varchar(20) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `cidade` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  `telefone` varchar(30) NOT NULL,
  `turma` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `professor`
--

INSERT INTO `professor` (`codprof`, `nome`, `rg`, `cpf`, `endereco`, `cidade`, `email`, `telefone`, `turma`) VALUES
(0, 'nome', 'rg', 'cpf', 'endereco', 'cidade', 'email', 'telefone', 'a'),
(4, 'Pedro', '111111111111', '222222222222222', 'sdadada', 'sadasda', 'asdsad@adsad', '13576799975', ''),
(5, 'Reginaldo', '333333333333', '44444444444', 'dfsdfds', 'ssfsfsffd', 'sdfdfsdf@asdsad', '1233434256', ''),
(6, 'Reginaldo', '45465768', '77789976567', 'sdfffsdff', 'wqerewttf', 'sdasda@ada', '123456789', 'a'),
(7, 'pedro', '1111111111', '2222222222', 'sadad', 'asdad', 'asdda', '1324467', 'ada');

-- --------------------------------------------------------

--
-- Estrutura para tabela `professor_turma`
--

CREATE TABLE `professor_turma` (
  `codigo` int(11) NOT NULL,
  `codprof` int(11) NOT NULL,
  `codturma` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `professor_turma`
--

INSERT INTO `professor_turma` (`codigo`, `codprof`, `codturma`) VALUES
(1, 0, 1),
(3, 4, 4),
(5, 4, 3),
(6, 4, 2),
(7, 4, 1),
(8, 5, 2),
(9, 5, 3),
(10, 5, 4);

-- --------------------------------------------------------

--
-- Estrutura para tabela `turma`
--

CREATE TABLE `turma` (
  `codturma` int(11) NOT NULL,
  `nomet` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Despejando dados para a tabela `turma`
--

INSERT INTO `turma` (`codturma`, `nomet`) VALUES
(1, 'ada'),
(2, 'a'),
(3, 'b'),
(4, 'c');

-- --------------------------------------------------------

--
-- Estrutura para view `aaa`
--
DROP TABLE IF EXISTS `aaa`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `aaa`  AS SELECT `aluno`.`nome` AS `nome_aluno`, `aluno_turma`.`codigo` AS `id`, `turma`.`nomet` AS `nome_turma` FROM ((`aluno_turma` join `aluno` on(`aluno`.`codaluno` = `aluno_turma`.`codaluno`)) join `turma` on(`turma`.`codturma` = `aluno_turma`.`codigo`)) ;

-- --------------------------------------------------------

--
-- Estrutura para view `aaa2`
--
DROP TABLE IF EXISTS `aaa2`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `aaa2`  AS SELECT `professor`.`nome` AS `nome_professor`, `professor_turma`.`codigo` AS `id`, `turma`.`nomet` AS `nome_turma` FROM ((`professor_turma` join `professor` on(`professor`.`codprof` = `professor`.`codprof`)) join `turma` on(`turma`.`codturma` = `professor_turma`.`codigo`)) ;

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `aluno`
--
ALTER TABLE `aluno`
  ADD PRIMARY KEY (`codaluno`);

--
-- Índices de tabela `aluno_turma`
--
ALTER TABLE `aluno_turma`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `fk_codturma` (`codturma`),
  ADD KEY `fk_codaluno` (`codaluno`);

--
-- Índices de tabela `expediente`
--
ALTER TABLE `expediente`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `fk_codfunc` (`codfunc`),
  ADD KEY `fk_codhorario` (`codhorario`);

--
-- Índices de tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`codfunc`);

--
-- Índices de tabela `horario`
--
ALTER TABLE `horario`
  ADD PRIMARY KEY (`codhorario`);

--
-- Índices de tabela `professor`
--
ALTER TABLE `professor`
  ADD PRIMARY KEY (`codprof`);

--
-- Índices de tabela `professor_turma`
--
ALTER TABLE `professor_turma`
  ADD PRIMARY KEY (`codigo`),
  ADD KEY `fk_codprof` (`codprof`),
  ADD KEY `fk_codigoturma` (`codturma`);

--
-- Índices de tabela `turma`
--
ALTER TABLE `turma`
  ADD PRIMARY KEY (`codturma`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `aluno`
--
ALTER TABLE `aluno`
  MODIFY `codaluno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de tabela `aluno_turma`
--
ALTER TABLE `aluno_turma`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `expediente`
--
ALTER TABLE `expediente`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `codfunc` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `horario`
--
ALTER TABLE `horario`
  MODIFY `codhorario` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `professor`
--
ALTER TABLE `professor`
  MODIFY `codprof` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `professor_turma`
--
ALTER TABLE `professor_turma`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `turma`
--
ALTER TABLE `turma`
  MODIFY `codturma` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `aluno_turma`
--
ALTER TABLE `aluno_turma`
  ADD CONSTRAINT `fk_codaluno` FOREIGN KEY (`codaluno`) REFERENCES `aluno` (`codaluno`),
  ADD CONSTRAINT `fk_codturma` FOREIGN KEY (`codturma`) REFERENCES `turma` (`codturma`);

--
-- Restrições para tabelas `expediente`
--
ALTER TABLE `expediente`
  ADD CONSTRAINT `fk_codfunc` FOREIGN KEY (`codfunc`) REFERENCES `funcionario` (`codfunc`),
  ADD CONSTRAINT `fk_codhorario` FOREIGN KEY (`codhorario`) REFERENCES `horario` (`codhorario`);

--
-- Restrições para tabelas `professor_turma`
--
ALTER TABLE `professor_turma`
  ADD CONSTRAINT `fk_codigoturma` FOREIGN KEY (`codturma`) REFERENCES `turma` (`codturma`),
  ADD CONSTRAINT `fk_codprof` FOREIGN KEY (`codprof`) REFERENCES `professor` (`codprof`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
