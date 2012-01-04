CREATE DATABASE  IF NOT EXISTS `store` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `store`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: store
-- ------------------------------------------------------
-- Server version	5.5.19
 

--
-- Table structure for table `purchasesitems`
--

DROP TABLE IF EXISTS `purchasesitems`; 
CREATE TABLE `purchasesitems` (
  `ID` int(11) unsigned NOT NULL DEFAULT '0',
  `PurchaseBills_BillID` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `Qty` double NOT NULL,
  `Cost` double NOT NULL,
  `Total` double NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_purchasesitems_items1` (`ItemID`),
  KEY `fk_purchasesitems_PurchaseBills1` (`PurchaseBills_BillID`),
  CONSTRAINT `fk_purchasesitems_items1` FOREIGN KEY (`ItemID`) REFERENCES `items` (`ItemID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_purchasesitems_PurchaseBills1` FOREIGN KEY (`PurchaseBills_BillID`) REFERENCES `purchasebills` (`BillID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
 

-- Dump completed on 2012-01-04 11:06:23
