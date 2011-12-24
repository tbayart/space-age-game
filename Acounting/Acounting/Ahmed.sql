SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL';

CREATE SCHEMA IF NOT EXISTS `Store` DEFAULT CHARACTER SET utf8 ;
USE `Store` ;

-- -----------------------------------------------------
-- Table `Store`.`items`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Store`.`items` (
  `ItemID` INT(11) NOT NULL DEFAULT '0' ,
  `ItemName` VARCHAR(255) CHARACTER SET 'utf8' NOT NULL ,
  `Cost` DOUBLE NOT NULL ,
  `Qty` DOUBLE NOT NULL ,
  `TotalCost` DOUBLE NOT NULL ,
  PRIMARY KEY (`ItemID`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
CHECKSUM = 1
COLLATE = utf8_general_ci
DELAY_KEY_WRITE = 1
ROW_FORMAT = DYNAMIC;


-- -----------------------------------------------------
-- Table `Store`.`Agents`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Store`.`Agents` (
  `AgentID` INT NOT NULL ,
  `AgentName` VARCHAR(45) CHARACTER SET 'utf8' NOT NULL ,
  `Address` VARCHAR(45) CHARACTER SET 'utf8' NULL ,
  `Telephone` VARCHAR(45) CHARACTER SET 'utf8' NULL ,
  `Debt` INT NOT NULL ,
  PRIMARY KEY (`AgentID`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Store`.`payments`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Store`.`payments` (
  `ID` INT(11) NOT NULL DEFAULT '0' ,
  `DocDate` DATE NOT NULL ,
  `Amount` DOUBLE NOT NULL ,
  `Agents_AgentID` INT NOT NULL ,
  PRIMARY KEY (`ID`) ,
  INDEX `fk_payments_Agents1` (`Agents_AgentID` ASC) ,
  CONSTRAINT `fk_payments_Agents1`
    FOREIGN KEY (`Agents_AgentID` )
    REFERENCES `Store`.`Agents` (`AgentID` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
CHECKSUM = 1
COLLATE = utf8_general_ci
DELAY_KEY_WRITE = 1
ROW_FORMAT = DYNAMIC;


-- -----------------------------------------------------
-- Table `Store`.`Dealers`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Store`.`Dealers` (
  `DealerID` INT NOT NULL ,
  `DealerName` VARCHAR(45) CHARACTER SET 'utf8' NOT NULL ,
  `Adress` VARCHAR(45) CHARACTER SET 'utf8' NULL ,
  `Telephone` VARCHAR(45) CHARACTER SET 'utf8' NULL,
  `Debt` INT NOT NULL ,
  PRIMARY KEY (`DealerID`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Store`.`PurchaseBills`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Store`.`PurchaseBills` (
  `BillID` INT NOT NULL ,
  `Dealers_DealerID` INT NOT NULL ,
  `DocDate` DATETIME NOT NULL ,
  `TotalBill` DOUBLE NOT NULL ,
  `Paid` DOUBLE NOT NULL ,
  `Remaining` DOUBLE NOT NULL ,
  PRIMARY KEY (`BillID`) ,
  INDEX `fk_PurchaseBills_Dealers1` (`Dealers_DealerID` ASC) ,
  CONSTRAINT `fk_PurchaseBills_Dealers1`
    FOREIGN KEY (`Dealers_DealerID` )
    REFERENCES `Store`.`Dealers` (`DealerID` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Store`.`purchasesitems`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Store`.`purchasesitems` (
  `ID` INT(11) UNSIGNED NOT NULL DEFAULT '0' ,
  `PurchaseBills_BillID` INT NOT NULL ,
  `ItemID` INT(11) NOT NULL ,
  `Qty` DOUBLE NOT NULL ,
  `Cost` DOUBLE NOT NULL ,
  `Total` DOUBLE NOT NULL ,
  PRIMARY KEY (`ID`) ,
  INDEX `fk_purchasesitems_items1` (`ItemID` ASC) ,
  INDEX `fk_purchasesitems_PurchaseBills1` (`PurchaseBills_BillID` ASC) ,
  CONSTRAINT `fk_purchasesitems_items1`
    FOREIGN KEY (`ItemID` )
    REFERENCES `Store`.`items` (`ItemID` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_purchasesitems_PurchaseBills1`
    FOREIGN KEY (`PurchaseBills_BillID` )
    REFERENCES `Store`.`PurchaseBills` (`BillID` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
CHECKSUM = 1
COLLATE = utf8_general_ci
DELAY_KEY_WRITE = 1
ROW_FORMAT = DYNAMIC;


-- -----------------------------------------------------
-- Table `Store`.`Bills`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Store`.`Bills` (
  `BillID` INT NOT NULL ,
  `Agents_AgentID` INT NOT NULL ,
  `DocDate` DATETIME NOT NULL ,
  `TotalBill` DOUBLE NOT NULL ,
  `Paid` DOUBLE NOT NULL ,
  `Remaining` DOUBLE NOT NULL ,
  PRIMARY KEY (`BillID`) ,
  INDEX `fk_Bills_Agents1` (`Agents_AgentID` ASC) ,
  CONSTRAINT `fk_Bills_Agents1`
    FOREIGN KEY (`Agents_AgentID` )
    REFERENCES `Store`.`Agents` (`AgentID` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Store`.`salesitems`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Store`.`salesitems` (
  `ID` INT(11) UNSIGNED NOT NULL DEFAULT '0' ,
  `Bills_BillID` INT NOT NULL ,
  `ItemID` INT(11) NOT NULL ,
  `Qty` DOUBLE NOT NULL ,
  `SellPrice` DOUBLE NOT NULL ,
  `Cost` DOUBLE NOT NULL ,
  `TotalPrice` DOUBLE NOT NULL ,
  `Earnings` DOUBLE NOT NULL ,
  PRIMARY KEY (`ID`) ,
  INDEX `fk_salesitems_items1` (`ItemID` ASC) ,
  INDEX `fk_salesitems_Bills1` (`Bills_BillID` ASC) ,
  CONSTRAINT `fk_salesitems_items1`
    FOREIGN KEY (`ItemID` )
    REFERENCES `Store`.`items` (`ItemID` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_salesitems_Bills1`
    FOREIGN KEY (`Bills_BillID` )
    REFERENCES `Store`.`Bills` (`BillID` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
CHECKSUM = 1
COLLATE = utf8_general_ci
DELAY_KEY_WRITE = 1
ROW_FORMAT = DYNAMIC;


-- -----------------------------------------------------
-- Table `Store`.`DealerPayments`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Store`.`DealerPayments` (
  `PaymentID` INT NOT NULL ,
  `DocDate` DATETIME NULL ,
  `Ammount` DOUBLE NOT NULL ,
  `Dealers_DealerID` INT NOT NULL ,
  PRIMARY KEY (`PaymentID`) ,
  INDEX `fk_DealerPayments_Dealers1` (`Dealers_DealerID` ASC) ,
  CONSTRAINT `fk_DealerPayments_Dealers1`
    FOREIGN KEY (`Dealers_DealerID` )
    REFERENCES `Store`.`Dealers` (`DealerID` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Store`.`Vault`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Store`.`Vault` (
  `idVault` INT NOT NULL ,
  `In_Hand` INT NOT NULL ,
  `Opennings` INT NOT NULL ,
  PRIMARY KEY (`idVault`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Store`.`Spendings`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `Store`.`Spendings` (
  `ID` INT(11) NOT NULL DEFAULT '0' ,
  `DocDate` DATE NOT NULL ,
  `Amount` DOUBLE NOT NULL ,
  PRIMARY KEY (`ID`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8
CHECKSUM = 1
COLLATE = utf8_general_ci
DELAY_KEY_WRITE = 1
ROW_FORMAT = DYNAMIC;


-- -----------------------------------------------------
-- Placeholder table for view `Store`.`Collected`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Store`.`Collected` (`CollectedTotal` INT);

-- -----------------------------------------------------
-- Placeholder table for view `Store`.`Paid`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Store`.`Paid` (`PaidTotal` INT);

-- -----------------------------------------------------
-- View `Store`.`Collected`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Store`.`Collected`;
USE `Store`;
CREATE  OR REPLACE VIEW `Store`.`Collected` AS SELECT        SUM(Amount) AS CollectedTotal
FROM            payments
;

-- -----------------------------------------------------
-- View `Store`.`Paid`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Store`.`Paid`;
USE `Store`;
CREATE  OR REPLACE VIEW `Store`.`Paid` AS SELECT        SUM(Ammount) AS PaidTotal
FROM            dealerpayments
;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
