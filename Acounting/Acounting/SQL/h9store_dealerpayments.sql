CREATE DATABASE  IF NOT EXISTS `store` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `store`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: store
-- ------------------------------------------------------
-- Server version	5.5.19

--
-- Table structure for table `dealerpayments`
--

DROP TABLE IF EXISTS `dealerpayments`;
CREATE TABLE `dealerpayments` (
  `PaymentID` int(11) NOT NULL,
  `DocDate` datetime DEFAULT NULL,
  `Ammount` double NOT NULL,
  `Dealers_DealerID` int(11) NOT NULL,
  PRIMARY KEY (`PaymentID`),
  KEY `fk_DealerPayments_Dealers1` (`Dealers_DealerID`),
  CONSTRAINT `fk_DealerPayments_Dealers1` FOREIGN KEY (`Dealers_DealerID`) REFERENCES `dealers` (`DealerID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dump completed on 2011-12-28  6:57:30
