-- -----------------------------------------------------
-- Schema cadastroclientes
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `cadastroclientes` DEFAULT CHARACTER SET utf8 ;
USE `cadastroclientes` ;

-- -----------------------------------------------------
-- Table `cadastroclientes`.`Perfil`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cadastroclientes`.`Perfil` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `Descricao` VARCHAR(45) NOT NULL,
  `Nivel` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `cadastroclientes`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE `usuarios` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `IDPerfil` int NOT NULL,
  `Nome` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL,
  `Senha` varchar(45) NOT NULL,
  `DataCria` datetime(6) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IDPerfil` (`IDPerfil`),
  CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`IDPerfil`) REFERENCES `perfil` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3

-- -----------------------------------------------------
-- Table `cadastroclientes`.`Clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `cadastrocliente`.`Cliente` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(45) NOT NULL,
  `Email` VARCHAR(45) NOT NULL,
  `Logradouro` VARCHAR(45) NOT NULL,
  `NumeroRes` VARCHAR(45) NOT NULL,
  `Complemento` VARCHAR(45) NOT NULL,
  `Cep` VARCHAR(45) NOT NULL,
  `Bairro` VARCHAR(45) NOT NULL,
  `Cidade` VARCHAR(45) NOT NULL,
  `Estado` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;
