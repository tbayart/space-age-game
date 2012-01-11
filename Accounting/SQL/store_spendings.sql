CREATE DATABASE  IF NOT EXISTS `store` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `store`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: store
-- ------------------------------------------------------
-- Server version	5.5.19
 
--
-- Table structure for table `spendings`
--

DROP TABLE IF EXISTS `spendings`; 
CREATE TABLE `spendings` (
  `ID` int(11) NOT NULL DEFAULT '0',
  `DocDate` date NOT NULL,
  `Amount` double NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;
 
-- Dump completed on 2012-01-04 11:06:22
