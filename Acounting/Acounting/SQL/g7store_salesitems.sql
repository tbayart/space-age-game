CREATE DATABASE  IF NOT EXISTS `store` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `store`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: store
-- ------------------------------------------------------
-- Server version	5.5.19


--
-- Table structure for table `salesitems`
--

DROP TABLE IF EXISTS `salesitems`;
CREATE TABLE `salesitems` (
  `ID` int(11) unsigned NOT NULL DEFAULT '0',
  `Bills_BillID` int(11) NOT NULL,
  `ItemID` int(11) NOT NULL,
  `Qty` double NOT NULL,
  `SellPrice` double NOT NULL,
  `Cost` double NOT NULL,
  `TotalPrice` double NOT NULL,
  `Earnings` double NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_salesitems_items1` (`ItemID`),
  KEY `fk_salesitems_Bills1` (`Bills_BillID`),
  CONSTRAINT `fk_salesitems_items1` FOREIGN KEY (`ItemID`) REFERENCES `items` (`ItemID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_salesitems_Bills1` FOREIGN KEY (`Bills_BillID`) REFERENCES `bills` (`BillID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci CHECKSUM=1 DELAY_KEY_WRITE=1 ROW_FORMAT=DYNAMIC;


-- Dump completed on 2011-12-28  6:57:31
