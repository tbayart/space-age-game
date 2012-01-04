CREATE DATABASE  IF NOT EXISTS `store` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `store`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: store
-- ------------------------------------------------------
-- Server version	5.5.19
 
--
-- Table structure for table `purchasebills`
--

DROP TABLE IF EXISTS `purchasebills`; 
CREATE TABLE `purchasebills` (
  `BillID` int(11) NOT NULL,
  `DocDate` date NOT NULL,
  `TotalBill` double NOT NULL,
  `Paid` double NOT NULL,
  `Remaining` double NOT NULL,
  `Names_ID` int(11) NOT NULL,
  PRIMARY KEY (`BillID`),
  KEY `fk_PurchaseBills_Names1` (`Names_ID`),
  CONSTRAINT `fk_PurchaseBills_Names1` FOREIGN KEY (`Names_ID`) REFERENCES `names` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 

-- Dump completed on 2012-01-04 11:06:24
