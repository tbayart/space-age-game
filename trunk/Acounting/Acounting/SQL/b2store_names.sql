CREATE DATABASE  IF NOT EXISTS `store` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `store`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: store
-- ------------------------------------------------------
-- Server version	5.5.19

 
--
-- Table structure for table `names`
--

DROP TABLE IF EXISTS `names`; 
CREATE TABLE `names` (
  `ID` int(11) NOT NULL,
  `Name` varchar(255) CHARACTER SET utf8 NOT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `Telephone` varchar(45) DEFAULT NULL,
  `Debt` double NOT NULL,
  `InitialDebt` double NOT NULL,
  `InitialDate` date NOT NULL,
  `TypeAgent` tinyint(1) NOT NULL,
  `TypeDealer` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci; 

-- Dump completed on 2012-01-04 11:06:22
