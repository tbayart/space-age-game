CREATE DATABASE  IF NOT EXISTS `store` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `store`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: store
-- ------------------------------------------------------
-- Server version	5.5.19
 
--
-- Table structure for table `moves`
--

DROP TABLE IF EXISTS `moves`; 
CREATE TABLE `moves` (
  `idMoves` int(11) NOT NULL,
  `Date` date NOT NULL,
  `MoveName` varchar(45) CHARACTER SET armscii8 NOT NULL,
  `MoveData` varchar(45) NOT NULL,
  `MoveData2` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idMoves`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 

-- Dump completed on 2012-01-04 11:06:22
