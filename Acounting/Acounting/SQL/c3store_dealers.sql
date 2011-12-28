CREATE DATABASE  IF NOT EXISTS `store` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `store`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: store
-- ------------------------------------------------------
-- Server version	5.5.19


--
-- Table structure for table `dealers`
--

DROP TABLE IF EXISTS `dealers`;
CREATE TABLE `dealers` (
  `DealerID` int(11) NOT NULL,
  `DealerName` varchar(45) NOT NULL,
  `Adress` varchar(45) DEFAULT NULL,
  `Telephone` varchar(45) DEFAULT NULL,
  `Debt` double NOT NULL,
  `InitialDebt` double NOT NULL,
  `InitialDate` date NOT NULL,
  PRIMARY KEY (`DealerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
-- Dump completed on 2011-12-28  6:57:30
