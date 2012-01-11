CREATE DATABASE  IF NOT EXISTS `store` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `store`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: store
-- ------------------------------------------------------
-- Server version	5.5.19
 
--
-- Table structure for table `vault`
--

DROP TABLE IF EXISTS `vault`; 
CREATE TABLE `vault` (
  `idVault` int(11) NOT NULL,
  `In_Hand` double NOT NULL,
  `Opennings` double NOT NULL,
  PRIMARY KEY (`idVault`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 

-- Dump completed on 2012-01-04 11:06:25
