CREATE DATABASE  IF NOT EXISTS `store` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `store`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: store
-- ------------------------------------------------------
-- Server version	5.5.19


--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
CREATE TABLE `payments` (
  `ID` int(11) NOT NULL DEFAULT '0',
  `DocDate` date NOT NULL,
  `Amount` double NOT NULL,
  `Agents_AgentID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_payments_Agents1` (`Agents_AgentID`),
  CONSTRAINT `fk_payments_Agents1` FOREIGN KEY (`Agents_AgentID`) REFERENCES `agents` (`AgentID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
-- Dump completed on 2011-12-28  6:57:32
