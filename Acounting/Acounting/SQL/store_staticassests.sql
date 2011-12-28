CREATE DATABASE  IF NOT EXISTS `store` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `store`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: store
-- ------------------------------------------------------
-- Server version	5.5.19

--
-- Table structure for table `staticassests`
--

DROP TABLE IF EXISTS `staticassests`;
CREATE TABLE `staticassests` (
  `Id` int(11) NOT NULL,
  `ItemName` varchar(45) NOT NULL,
  `Qty` double NOT NULL,
  `Cost` double NOT NULL,
  `TotalCost` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dump completed on 2011-12-28  6:57:28
