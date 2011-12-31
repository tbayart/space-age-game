CREATE DATABASE  IF NOT EXISTS `store` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `store`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: store
-- ------------------------------------------------------
-- Server version	5.5.19

--
-- Table structure for table `billsreturn`
--

DROP TABLE IF EXISTS `billsreturn`;
CREATE TABLE `billsreturn` (
  `BillID` int(11) NOT NULL,
  `Agents_AgentID` int(11) NOT NULL,
  `DocDate` date NOT NULL,
  `TotalBill` double NOT NULL,
  `Paid` double NOT NULL,
  `Remaining` double NOT NULL,
  PRIMARY KEY (`BillID`),
  KEY `fk_Bills_Agents1` (`Agents_AgentID`),
  CONSTRAINT `fk_Bills_Agents10` FOREIGN KEY (`Agents_AgentID`) REFERENCES `agents` (`AgentID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dump completed on 2011-12-28  6:57:32
