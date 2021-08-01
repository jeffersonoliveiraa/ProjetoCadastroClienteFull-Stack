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
CREATE TABLE IF NOT EXISTS `cadastroclientes`.`Usuario` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(45) NOT NULL,
  `Email` VARCHAR(45) NOT NULL,
  `Senha` VARCHAR(45) NOT NULL,
  `DataCria` DATETIME(6) NOT NULL,
  `Perfil` INT NOT NULL,
  PRIMARY KEY (`ID`),
  INDEX `IDPerfil_idx` (`Perfil` ASC) VISIBLE,
  CONSTRAINT `IDPerfil`
    FOREIGN KEY (`Perfil`)
    REFERENCES `cadastroclientes`.`Perfil` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

2
CREATE TABLE IF NOT EXISTS `cadastroclientes`.`Usuario` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(45) NOT NULL,
  `Email` VARCHAR(45) NOT NULL,
  `Senha` VARCHAR(45) NOT NULL,
  `DataCria` DATETIME(6) NOT NULL,
  `IDPerfil` INT NOT NULL,
  PRIMARY KEY (`ID`),
  INDEX `IDPerfil` (`IDPerfil` ASC) VISIBLE,
  CONSTRAINT `IDPerfil`
    FOREIGN KEY (`IDPerfil`)
    REFERENCES `cadastroclientes`.`Perfil` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

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